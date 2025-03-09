using System.Text.Json.Serialization;

namespace TaskManagerApp.Models;

public class ProjectTask
{
    public int ID { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime DueDate { get; set; }
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }

    [JsonIgnore]
    public int ProjectID { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}