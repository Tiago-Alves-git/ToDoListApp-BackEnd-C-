using Microsoft.EntityFrameworkCore;
using Models;
using Task = Models.Task;


namespace Repository
{
  public interface IToDoContext
  {
    public DbSet<Task>? Tasks { get; set; }
    public int SaveChanges();
  }
}
