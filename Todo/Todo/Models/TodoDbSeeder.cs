using Microsoft.EntityFrameworkCore;


namespace TodoMVC.Models;
public class TodoDbSeeder
{
    public static void Seed(IServiceProvider serviceProvider)
    {
        using var context = new TodoDbContext(serviceProvider.GetRequiredService<DbContextOptions<TodoDbContext>>());
        // Look for any todos.
        if (context.Todos.Any())
        {
            //if we get here then the data already seeded
            return;
        }
        context.Todos.AddRange(
            new Todo
            {
                Id = 1,
                TaskName = "Work on book chapter",
                IsComplete = false
            },
            new Todo
            {
                Id = 2,
                TaskName = "Create video content",
                IsComplete = false
            }
            );
        context.SaveChanges();

    }
}
