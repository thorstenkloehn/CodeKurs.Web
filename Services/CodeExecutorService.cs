using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System.Text.RegularExpressions;

namespace CodeKurs.Web.Services;

public class CodeExecutorService
{
    public async Task<ExecutionResult> ExecuteAsync(string code, string language)
    {
        switch (language.ToLower())
        {
            case "java":
                return await ExecuteJavaAsync(code);
            case "csharp":
            case "cs":
                return await ExecuteCSharpAsync(code);
            case "javascript":
            case "js":
                return await ExecuteJavaScriptAsync(code);
            default:
                return await ExecuteCSharpAsync(code);
        }
    }

    public async Task<ExecutionResult> ExecuteCSharpAsync(string code)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(code);
        var references = new List<MetadataReference>
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
            MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
            MetadataReference.CreateFromFile(Assembly.Load("netstandard").Location)
        };

        var compilation = CSharpCompilation.Create(
            Path.GetRandomFileName(),
            new[] { syntaxTree },
            references,
            new CSharpCompilationOptions(OutputKind.ConsoleApplication));

        var result = new ExecutionResult();
        var diagnostics = compilation.GetDiagnostics();
        result.Errors = diagnostics
            .Where(d => d.Severity == DiagnosticSeverity.Error || d.Severity == DiagnosticSeverity.Warning)
            .Select(d => new EditorError 
            { 
                Line = d.Location.GetLineSpan().StartLinePosition.Line + 1,
                Message = d.GetMessage(),
                IsWarning = d.Severity == DiagnosticSeverity.Warning
            }).ToList();

        if (diagnostics.Any(d => d.Severity == DiagnosticSeverity.Error))
        {
            result.Output = "Kompilierfehler.";
            return result;
        }

        using var ms = new MemoryStream();
        EmitResult emitResult = compilation.Emit(ms);
        if (!emitResult.Success) { result.Output = "Fehler beim Erzeugen der Assembly."; return result; }

        ms.Seek(0, SeekOrigin.Begin);
        var assembly = Assembly.Load(ms.ToArray());
        var entryPoint = assembly.EntryPoint;
        if (entryPoint == null) { result.Output = "Fehler: Kein Einstiegspunkt gefunden."; return result; }

        var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);
        try
        {
            var parameters = entryPoint.GetParameters().Length > 0 ? new object[] { Array.Empty<string>() } : null;
            entryPoint.Invoke(null, parameters);
            result.Output = sw.ToString();
            return result;
        }
        catch (Exception ex) { result.Output = $"Laufzeitfehler: {ex.InnerException?.Message ?? ex.Message}"; return result; }
        finally { Console.SetOut(originalOut); }
    }

    public async Task<ExecutionResult> ExecuteJavaAsync(string code)
    {
        return await RunExternalProcessAsync("javac", "Program.java", "java", "Program", code, "Program.java", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"Program\.java:(\d+): error: (.*)");
            foreach (Match m in regex.Matches(err))
                errors.Add(new EditorError { Line = int.Parse(m.Groups[1].Value), Message = m.Groups[2].Value.Trim() });
            return errors;
        });
    }

    public async Task<ExecutionResult> ExecuteJavaScriptAsync(string code)
    {
        // Validation with node --check
        var result = await RunExternalProcessAsync("node", "--check script.js", "node", "script.js", code, "script.js", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"script\.js:(\d+)\n(.*)\n(.*)\nSyntaxError: (.*)");
            var match = Regex.Match(err, @"script\.js:(\d+).*?SyntaxError: (.*)", RegexOptions.Singleline);
            if (match.Success)
                errors.Add(new EditorError { Line = int.Parse(match.Groups[1].Value), Message = match.Groups[2].Value.Trim() });
            return errors;
        });
        return result;
    }

    private async Task<ExecutionResult> RunExternalProcessAsync(string compileCmd, string compileArgs, string runCmd, string runArgs, string code, string fileName, Func<string, List<EditorError>> errorParser)

    {
        string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempDir);
        await File.WriteAllTextAsync(Path.Combine(tempDir, fileName), code);
        var result = new ExecutionResult();
        try
        {
            // Compile/Check
            var cStartInfo = new System.Diagnostics.ProcessStartInfo(compileCmd, compileArgs) { WorkingDirectory = tempDir, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
            using var cProc = System.Diagnostics.Process.Start(cStartInfo);
            string cErr = await cProc!.StandardError.ReadToEndAsync();
            await cProc.WaitForExitAsync();

            if (cProc.ExitCode != 0)
            {
                result.Output = "Syntaxfehler/Kompilierfehler.";
                result.Errors = errorParser(cErr);
                return result;
            }

            // Run
            var rStartInfo = new System.Diagnostics.ProcessStartInfo(runCmd, runArgs) { WorkingDirectory = tempDir, RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
            using var rProc = System.Diagnostics.Process.Start(rStartInfo);
            result.Output = await rProc!.StandardOutput.ReadToEndAsync();
            string rErr = await rProc.StandardError.ReadToEndAsync();
            await rProc.WaitForExitAsync();
            if (!string.IsNullOrEmpty(rErr)) result.Output += "\nFehler:\n" + rErr;
            return result;
        }
        catch (Exception ex) { result.Output = "Fehler: " + ex.Message; return result; }
        finally { try { Directory.Delete(tempDir, true); } catch { } }
    }
}

public class ExecutionResult
{
    public string Output { get; set; } = "";
    public List<EditorError> Errors { get; set; } = new();
}

public class EditorError
{
    public int Line { get; set; }
    public string Message { get; set; } = "";
    public bool IsWarning { get; set; }
}
