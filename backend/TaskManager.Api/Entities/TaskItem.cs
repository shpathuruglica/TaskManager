namespace TaskManager.Api.Entities;

public enum TaskPriority
{
    Low,
    Medium,
    High,
    Critical
}

public enum TaskItemStatus
{
    ToDo,
    InProgress,
    Review,
    Done
}

public class TaskItem
{
    public int Id { get; set; }
    public int ProjectId { get; set; }

    public int? SprintId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskItemStatus Status { get; set; }
    public string? AssignedToId { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime CreatedAt { get; set; }

}
