using CodeKurs.Web.Models;

namespace CodeKurs.Web.Models;

public class DashboardViewModel
{
    public int TotalTasks { get; set; }
    public int CompletedTasks { get; set; }
    public double ProgressPercentage => TotalTasks > 0 ? (double)CompletedTasks / TotalTasks * 100 : 0;
    
    public List<TaskProgressInfo> TaskDetails { get; set; } = new();
    
    public Dictionary<string, LanguageStatInfo> LanguageStats { get; set; } = new();
}

public class LanguageStatInfo
{
    public int Total { get; set; }
    public int Completed { get; set; }
    public double Percentage => Total > 0 ? (double)Completed / Total * 100 : 0;
}

public class TaskProgressInfo
{
    public int TaskId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
    public TaskType Type { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? LastUpdated { get; set; }
}
