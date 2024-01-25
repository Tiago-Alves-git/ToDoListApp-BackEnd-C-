// Controllers/TasksController.cs
using Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository;
using System.Collections.Generic;
using Task = Models.Task;

namespace Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
  private readonly ITasksRepository _repository;

  public TasksController(ITasksRepository repository)
  {
    _repository = repository;
  }

  // GET: api/Tasks
  [HttpGet]
  public IActionResult GetTasks()
  {
    try
    {
      var tasks = _repository.GetTasks();
      return Ok(tasks);
    }
    catch
    {
      return StatusCode(500, "Internal Error");
    }
  }

  // POST: api/Tasks
  [HttpPost]
  public IActionResult Add([FromBody] TaskDtoInsert newtask)
  {
    var addTask = _repository.AddTasks(newtask);
    if (addTask != null)
    {
      return Ok();
    }
    else
    {
      return BadRequest();
    }
  }

  [HttpPut]
  public IActionResult UpdateTask([FromBody] Task updateTask)
  {
    var updatedTask = _repository.UpdateTasks(updateTask);
    if (updatedTask != null)
    {
      return Ok(updatedTask);
    }
    else
    {
      return BadRequest();
    }
  }

  [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            try
            {
                var deletedTask = _repository.DeleteTask(id);
                if (deletedTask != null)
                {
                    return Ok(deletedTask);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(500, "Internal Error");
            }
        }
}
