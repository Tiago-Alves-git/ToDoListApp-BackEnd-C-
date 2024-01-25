using Dto;
using Task = Models.Task;


namespace Repository
{
  public interface ITasksRepository
  {
    IEnumerable<TaskDto> GetTasks();
    TaskDtoResponse AddTasks(TaskDtoInsert task);
    TaskDto UpdateTasks(Task task);
    TaskDto DeleteTask(int id);
  }
}