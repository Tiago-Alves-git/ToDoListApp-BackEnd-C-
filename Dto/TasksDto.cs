namespace Dto

{
  public class TaskDto
  {
    public int TaskId { get; set; }
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
    public string? Description { get; set; }
  }
}