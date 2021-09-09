using Microsoft.AspNetCore.Mvc;
using TodoMVC.Models;

namespace TodoMVC.Controllers;
public class TodoController : Controller
{
    private readonly TodoDbContext _dbContext;
    public TodoController(TodoDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var todos = _dbContext.Todos.ToList();
        return View(todos);
    }
}
