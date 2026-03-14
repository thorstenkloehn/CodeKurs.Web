using Microsoft.EntityFrameworkCore;
using CodeKurs.Web.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Markdig;

namespace CodeKurs.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<ProgrammingTask> Tasks { get; set; }
    public DbSet<UserProgress> Progress { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        SeedFromMarkdown(modelBuilder);
    }

    private void SeedFromMarkdown(ModelBuilder modelBuilder)
    {
        var rootPath = Path.Combine(Directory.GetCurrentDirectory(), "lernen");
        if (!Directory.Exists(rootPath)) return;

        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .IgnoreUnmatchedProperties()
            .Build();

        int lessonIdCounter = 100;
        int taskIdCounter = 1000;

        var markdownFiles = Directory.GetFiles(rootPath, "*.md", SearchOption.AllDirectories);

        foreach (var file in markdownFiles)
        {
            var content = File.ReadAllText(file);
            var parts = content.Split("---", 3, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2) continue;

            var yaml = parts[0];
            var markdownBody = parts.Length > 1 ? parts[1].Trim() : "";
            
            var fm = deserializer.Deserialize<LessonFrontMatter>(yaml);

            // Markdown zu HTML konvertieren
            var htmlBody = Markdown.ToHtml(markdownBody);
            var fullDescription = !string.IsNullOrEmpty(fm.Description) 
                ? $"<p>{fm.Description}</p>{htmlBody}" 
                : htmlBody;

            var lesson = new Lesson
            {
                Id = lessonIdCounter++,
                Title = fm.Title,
                Description = fullDescription,
                Order = fm.Order,
                Language = fm.Language
            };

            modelBuilder.Entity<Lesson>().HasData(lesson);

            if (fm.Tasks != null)
            {
                foreach (var t in fm.Tasks)
                {
                    var task = new ProgrammingTask
                    {
                        Id = taskIdCounter++,
                        LessonId = lesson.Id,
                        Title = t.Title,
                        Description = t.Description,
                        Type = Enum.Parse<TaskType>(t.Type),
                        Order = t.Order,
                        Language = lesson.Language,
                        InitialCode = t.InitialCode ?? "",
                        ExpectedOutput = t.ExpectedOutput ?? "",
                        RequiredKeywords = t.RequiredKeywords,
                        TestCode = t.TestCode
                    };
                    modelBuilder.Entity<ProgrammingTask>().HasData(task);
                }
            }
        }
    }

    private class LessonFrontMatter
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int Order { get; set; }
        public string Language { get; set; } = "";
        public List<TaskFrontMatter>? Tasks { get; set; }
    }

    private class TaskFrontMatter
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Type { get; set; } = "Programming";
        public int Order { get; set; }
        public string? InitialCode { get; set; }
        public string? ExpectedOutput { get; set; }
        public string? RequiredKeywords { get; set; }
        public string? TestCode { get; set; }
    }
}
