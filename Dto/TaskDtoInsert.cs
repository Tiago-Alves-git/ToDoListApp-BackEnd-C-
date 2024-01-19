
namespace Dto;
public class TaskDtoInsert
{
  public string? Title { get; set; }
  public string? Description { get; set; }
  public bool IsCompleted { get; set; }
}
public class TaskDtoResponse
{
  public int? TaskId { get; set; }

  public string? Title { get; set; }

  public string? Description { get; set; }

  public bool IsCompleted { get; set; }
}