namespace TaskManager.Api.Entities;

public enum ProjectStatus
{
    Planned,
    Active,
    Completed,
    Archived
}

public class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public ProjectStatus Status { get; set; }

    public string OwnerId { get; set; } = string.Empty;
}
