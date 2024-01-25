using Models;
using Dto;
using Task = Models.Task;

namespace Repository;
public class TasksRepository : ITasksRepository
{
  protected readonly ToDoContext _context;

  public TasksRepository(ToDoContext context)
  {
    _context = context;
  }

  public IEnumerable<TaskDto> GetTasks()
  {
    return _context.Tasks!
    .Select(task => new TaskDto
    {
      TaskId = task.TaskId,
      Title = task.Title,
      IsCompleted = task.IsCompleted,
      Description = task.Description
    })
    .ToList();
  }

  TaskDtoResponse ITasksRepository.AddTasks(TaskDtoInsert task)
  {
    try
    {
      var newTask = new Task
      {
        Title = task.Title,
        IsCompleted = task.IsCompleted,
        Description = task.Description,
      };
      _context.Add(newTask);
      _context.SaveChanges();
      var newResponse = new TaskDtoResponse
      {
        TaskId = newTask.TaskId,
        Title = newTask.Title,
        IsCompleted = newTask.IsCompleted,
        Description = newTask.Description
      };
      return newResponse;
    }
    catch (System.Exception)
    {
      throw new Exception("Erro ao adicionar nova tarefa");
    }
  }

  TaskDto ITasksRepository.UpdateTasks(Task task)
  {
    var updatedTask = _context.Tasks!.FirstOrDefault((id) => id.TaskId == task.TaskId);
    if (updatedTask != null)
    {
      updatedTask.Title = task.Title;
      updatedTask.IsCompleted = task.IsCompleted;
      updatedTask.Description = task.Description;
      _context.SaveChanges();
      return new TaskDto
      {
        Title = task.Title,
        TaskId = updatedTask.TaskId,
        Description = task.Description,
        IsCompleted = task.IsCompleted
      };
    }
    return null!;
  }

   public TaskDto DeleteTask(int id)
        {
            // Implementação básica: Procura a tarefa pelo ID e a remove.
            var taskToDelete = _context.Tasks.FirstOrDefault(t => t.TaskId == id);

            if (taskToDelete != null)
            {
                _context.Tasks.Remove(taskToDelete);
                _context.SaveChanges();

                var newResponse = new TaskDtoResponse
                 {
                  TaskId = taskToDelete.TaskId,
                  Title = taskToDelete.Title,
                  IsCompleted = taskToDelete.IsCompleted,
                  Description = taskToDelete.Description
                  };
                  return newResponse;
            }

            return null; // Retorna null se a tarefa com o ID fornecido não foi encontrada.
        }
}
