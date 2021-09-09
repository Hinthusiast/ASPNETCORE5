using Microsoft.EntityFrameworkCore;

namespace TodoMVC.Models;
public class TodoDbContext: DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
}
