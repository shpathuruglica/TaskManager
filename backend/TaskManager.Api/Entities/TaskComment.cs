namespace TaskManager.Api.Entities;

public class TaskComment
{
    public int Id { get; set; }
    public int TaskId { get; set; }
    public string UserId { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

}
