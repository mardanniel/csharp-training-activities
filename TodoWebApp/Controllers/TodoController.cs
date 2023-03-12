using Microsoft.AspNetCore.Mvc;
using TodoWebApp.Models;
using TodoWebApp.Repository.InMemory;

namespace TodoWebApp.Controllers
{
  public class TodoController : Controller
  {
    InMemoryRepository imr = new InMemoryRepository();
    public IActionResult GetAllTodos()
    {
      List<Todo> todoList = imr.GetAllTodos();
      return View(todoList);
    }

    public IActionResult Details(int todoId)
    {
        Todo? todoDetails = imr.GetTodoById(todoId);
        return View(todoDetails);
    }

    public IActionResult Add()
    {
      return View();
    }

    public IActionResult Delete(int todoId)
    {
      imr.DeleteTodoById(todoId);
      return RedirectToAction(controllerName: "Todo", actionName: "GetAllTodos");
    }
  }
}
