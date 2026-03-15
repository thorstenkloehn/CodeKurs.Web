using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System.Text.RegularExpressions;

namespace CodeKurs.Web.Services;

public class CodeExecutorService
{
    public async Task<ExecutionResult> ExecuteAsync(string code, string language, string? input = null)
    {
        switch (language.ToLower())
        {
            case "java":
                return await ExecuteJavaAsync(code, input);
            case "csharp":
            case "cs":
                return await ExecuteCSharpAsync(code, input);
            case "javascript":
            case "js":
                return await ExecuteJavaScriptAsync(code, input);
            case "go":
                return await ExecuteGoAsync(code, input);
            case "php":
                return await ExecutePhpAsync(code, input);
            case "python":
            case "py":
                return await ExecutePythonAsync(code, input);
            case "c":
                return await ExecuteCAsync(code, input);
            case "rust":
                return await ExecuteRustAsync(code, input);
            case "cpp":
                return await ExecuteCppAsync(code, input);
            case "geminicli":
                return await ExecuteGeminiCliAsync(code, input);
            case "aspnetcore":
                return await ExecuteAspNetCoreAsync(code, input);
            case "springboot":
                return await ExecuteSpringBootAsync(code, input);
            default:
                return await ExecuteCSharpAsync(code, input);
        }
    }

    public async Task<ExecutionResult> ExecuteAspNetCoreAsync(string code, string? input = null)
    {
        // Mock für ASP.NET Core - Validiert Syntax grob und simuliert Erfolg
        if (code.Contains("Controller") || code.Contains("WebApplication"))
        {
            return await Task.FromResult(new ExecutionResult { Output = "ASP.NET Core Server simuliert gestartet...\nEndpoint 'GET /' aufgerufen.\nResult: 200 OK" });
        }
        return await Task.FromResult(new ExecutionResult { Output = "Kompilierfehler: Fehlender Controller oder App-Setup." });
    }

    public async Task<ExecutionResult> ExecuteSpringBootAsync(string code, string? input = null)
    {
        // Mock für Spring Boot
        if (code.Contains("@SpringBootApplication") || code.Contains("@RestController"))
        {
            return await Task.FromResult(new ExecutionResult { Output = "Spring Boot 4 Application Context gestartet...\nTomcat (Virtual Threads) auf Port 8080 aktiv.\nAntwort: Spring 4" });
        }
        return await Task.FromResult(new ExecutionResult { Output = "Kompilierfehler: Keine Spring Boot Application gefunden." });
    }

    public async Task<ExecutionResult> ExecuteGeminiCliAsync(string code, string? input = null)
    {
        // Mock-Executor für Gemini CLI Simulation
        // Gibt einfach den Code zurück, um Befehlsaufrufe zu simulieren
        return await Task.FromResult(new ExecutionResult { Output = code.Trim() });
    }

    public async Task<ExecutionResult> ExecuteCppAsync(string code, string? input = null)
    {
        // C++ execution with g++
        string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        string binaryName = "main_binary";
        string fullBinaryPath = Path.Combine(tempDir, binaryName);

        return await RunExternalProcessInDirAsync(tempDir, "g++", $"main.cpp -o {binaryName}", fullBinaryPath, "", code, "main.cpp", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"main\.cpp:(\d+):(\d+): (?:error|warning): (.*)");
            foreach (Match m in regex.Matches(err))
            {
                errors.Add(new EditorError 
                { 
                    Line = int.Parse(m.Groups[1].Value), 
                    Message = m.Groups[3].Value.Trim(),
                    IsWarning = err.Contains("warning")
                });
            }
            return errors;
        }, input);
    }

    public async Task<ExecutionResult> ExecuteRustAsync(string code, string? input = null)
    {
        // Rust execution with rustc
        string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        string binaryName = "main_binary";
        string fullBinaryPath = Path.Combine(tempDir, binaryName);

        return await RunExternalProcessInDirAsync(tempDir, "rustc", $"main.rs -o {binaryName}", fullBinaryPath, "", code, "main.rs", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"main\.rs:(\d+):(\d+): (?:error|warning): (.*)");
            foreach (Match m in regex.Matches(err))
            {
                errors.Add(new EditorError 
                { 
                    Line = int.Parse(m.Groups[1].Value), 
                    Message = m.Groups[3].Value.Trim(),
                    IsWarning = err.Contains("warning")
                });
            }
            return errors;
        }, input);
    }

    public async Task<ExecutionResult> ExecuteCAsync(string code, string? input = null)
    {
        // C execution with gcc
        string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        string binaryName = "main_binary";
        string fullBinaryPath = Path.Combine(tempDir, binaryName);

        return await RunExternalProcessInDirAsync(tempDir, "gcc", $"main.c -o {binaryName}", fullBinaryPath, "", code, "main.c", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"main\.c:(\d+):(\d+): (?:error|warning): (.*)");
            foreach (Match m in regex.Matches(err))
            {
                errors.Add(new EditorError 
                { 
                    Line = int.Parse(m.Groups[1].Value), 
                    Message = m.Groups[3].Value.Trim(),
                    IsWarning = err.Contains("warning")
                });
            }
            return errors;
        }, input);
    }

    private async Task<ExecutionResult> RunExternalProcessInDirAsync(string tempDir, string compileCmd, string compileArgs, string runCmd, string runArgs, string code, string fileName, Func<string, List<EditorError>> errorParser, string? input = null)
    {
        if (!Directory.Exists(tempDir)) Directory.CreateDirectory(tempDir);
        await File.WriteAllTextAsync(Path.Combine(tempDir, fileName), code);
        var result = new ExecutionResult();
        try
        {
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

            var rStartInfo = new System.Diagnostics.ProcessStartInfo(runCmd, runArgs) { WorkingDirectory = tempDir, RedirectStandardOutput = true, RedirectStandardError = true, RedirectStandardInput = true, UseShellExecute = false, CreateNoWindow = true };
            using var rProc = System.Diagnostics.Process.Start(rStartInfo);
            
            if (!string.IsNullOrEmpty(input))
            {
                await rProc!.StandardInput.WriteLineAsync(input);
                await rProc.StandardInput.FlushAsync();
                rProc.StandardInput.Close();
            }

            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            try 
            {
                await rProc!.WaitForExitAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                rProc!.Kill(true);
                result.Output = "Fehler: Zeitlimit von 5 Sekunden überschritten (Endlosschleife?).";
                return result;
            }

            result.Output = await rProc.StandardOutput.ReadToEndAsync();
            string rErr = await rProc.StandardError.ReadToEndAsync();
            if (!string.IsNullOrEmpty(rErr)) result.Output += "\nFehler:\n" + rErr;
            return result;
        }
        catch (Exception ex) { result.Output = "Fehler: " + ex.Message; return result; }
        finally { try { Directory.Delete(tempDir, true); } catch { } }
    }

    public async Task<ExecutionResult> ExecutePythonAsync(string code, string? input = null)
    {
        return await RunExternalProcessAsync("python", "-m py_compile script.py", "python", "script.py", code, "script.py", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"File ""script\.py"", line (\d+).*?\n(.*?SyntaxError: .*)", RegexOptions.Singleline);
            var match = regex.Match(err);
            if (match.Success)
            {
                errors.Add(new EditorError { Line = int.Parse(match.Groups[1].Value), Message = match.Groups[2].Value.Trim() });
            }
            return errors;
        }, input);
    }

    public async Task<ExecutionResult> ExecutePhpAsync(string code, string? input = null)
    {
        return await RunExternalProcessAsync("php", "-l script.php", "php", "script.php", code, "script.php", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"PHP (?:Parse|Fatal) error:  (.*) in script\.php on line (\d+)");
            var matches = regex.Matches(err);
            foreach (Match m in matches)
            {
                errors.Add(new EditorError { Line = int.Parse(m.Groups[2].Value), Message = m.Groups[1].Value.Trim() });
            }
            return errors;
        }, input);
    }

    public async Task<ExecutionResult> ExecuteGoAsync(string code, string? input = null)
    {
        return await RunExternalProcessAsync("go", "build -o /dev/null main.go", "go", "run main.go", code, "main.go", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"main\.go:(\d+):(\d+): (.*)");
            foreach (Match m in regex.Matches(err))
            {
                errors.Add(new EditorError { Line = int.Parse(m.Groups[1].Value), Message = m.Groups[3].Value.Trim() });
            }
            return errors;
        }, input);
    }

    public async Task<ExecutionResult> ExecuteCSharpAsync(string code, string? input = null)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(code);
        var references = new List<MetadataReference>
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
            MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
            MetadataReference.CreateFromFile(Assembly.Load("netstandard").Location)
        };

        var compilation = CSharpCompilation.Create(Path.GetRandomFileName(), new[] { syntaxTree }, references, new CSharpCompilationOptions(OutputKind.ConsoleApplication));
        var result = new ExecutionResult();
        var diagnostics = compilation.GetDiagnostics();
        result.Errors = diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error || d.Severity == DiagnosticSeverity.Warning)
            .Select(d => new EditorError { Line = d.Location.GetLineSpan().StartLinePosition.Line + 1, Message = d.GetMessage(), IsWarning = d.Severity == DiagnosticSeverity.Warning }).ToList();

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
        var originalIn = Console.In;
        Console.SetOut(sw);
        if (!string.IsNullOrEmpty(input)) Console.SetIn(new StringReader(input));
        try
        {
            var parameters = entryPoint.GetParameters().Length > 0 ? new object[] { Array.Empty<string>() } : null;
            entryPoint.Invoke(null, parameters);
            result.Output = sw.ToString();
            return result;
        }
        catch (Exception ex) { result.Output = $"Laufzeitfehler: {ex.InnerException?.Message ?? ex.Message}"; return result; }
        finally { Console.SetOut(originalOut); Console.SetIn(originalIn); }
    }

    public async Task<ExecutionResult> ExecuteJavaAsync(string code, string? input = null)
    {
        return await RunExternalProcessAsync("javac", "Program.java", "java", "Program", code, "Program.java", (err) => {
            var errors = new List<EditorError>();
            var regex = new Regex(@"Program\.java:(\d+): error: (.*)");
            foreach (Match m in regex.Matches(err))
                errors.Add(new EditorError { Line = int.Parse(m.Groups[1].Value), Message = m.Groups[2].Value.Trim() });
            return errors;
        }, input);
    }

    public async Task<ExecutionResult> ExecuteJavaScriptAsync(string code, string? input = null)
    {
        return await RunExternalProcessAsync("node", "--check script.js", "node", "script.js", code, "script.js", (err) => {
            var errors = new List<EditorError>();
            var match = Regex.Match(err, @"script\.js:(\d+).*?SyntaxError: (.*)", RegexOptions.Singleline);
            if (match.Success)
                errors.Add(new EditorError { Line = int.Parse(match.Groups[1].Value), Message = match.Groups[2].Value.Trim() });
            return errors;
        }, input);
    }

    private async Task<ExecutionResult> RunExternalProcessAsync(string compileCmd, string compileArgs, string runCmd, string runArgs, string code, string fileName, Func<string, List<EditorError>> errorParser, string? input = null)
    {
        string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        return await RunExternalProcessInDirAsync(tempDir, compileCmd, compileArgs, runCmd, runArgs, code, fileName, errorParser, input);
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
