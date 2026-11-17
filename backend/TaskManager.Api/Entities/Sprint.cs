namespace TaskManager.Api.Entities;

public enum SprintStatus
{
    Planned,
    Active,
    Completed
}


public class Sprint
{
    
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public SprintStatus Status { get; set; }
}
