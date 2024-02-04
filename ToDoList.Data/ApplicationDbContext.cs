using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ToDoList.Domain.Models;

namespace ToDoList.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<TaskModel> TaskModels => Set<TaskModel>();
    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder option)
    {
        option.UseNpgsql("Host=localhost;Port=5432;Database=TaskModel;Username=postgres;Password=Paradise71");
    }
}