// Models/TaskItem.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models;
public class Task
{
  public int TaskId { get; set; } // Chave primária
  public string? Title { get; set; }
  public bool IsCompleted { get; set; }
  public string? Description { get; set; }
}
