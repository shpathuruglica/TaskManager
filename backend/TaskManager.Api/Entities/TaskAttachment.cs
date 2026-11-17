namespace TaskManager.Api.Entities;

public class TaskAttachment
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string FileName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public DateTime UploadedAt { get; set; }

}