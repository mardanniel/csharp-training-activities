using Microsoft.AspNetCore.Mvc;
using TodoWebApp.Models;
using TodoWebApp.Repository.InMemory;
using TodoWebApp.ViewModels;

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

    public IActionResult Test(){

      // 3 ways to pass data to view
      // 1. ViewData
      ViewData["Name"] = "Hotdog";
      // 2. ViewBag
      ViewBag.Something = "Hahaha";
      // 3. Strongly Types - ex. Model
      Todo todo = imr.GetTodoById(0);

      //  ViewModel
      SomeActionViewModel smvm = new SomeActionViewModel();
      smvm.todo = todo;
      smvm.user = "Something";


      // return View(todo);

      return View(smvm);
    }
  }
}
