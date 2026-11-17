namespace TaskManager.Api.Entities;

public enum ProjectRole
{
    Owner,
    Admin,
    Member,
    Viewer
}


public class ProjectMember
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string UserId { get; set; } = string.Empty;

    public ProjectRole RoleInProject { get; set; }
}
