using Microsoft.EntityFrameworkCore;
using Models;
using Task = Models.Task;

namespace Repository;

public class ToDoContext : DbContext, IToDoContext
{
  public DbSet<Task>? Tasks { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Task>().HasKey(t => t.TaskId);
  }
}