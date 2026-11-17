namespace TaskManager.Api.Entities;

public class ActivityLog
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string UserId { get; set; } = string.Empty;

    public string Action { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}