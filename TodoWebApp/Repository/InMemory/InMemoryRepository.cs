using TodoWebApp.Models;

namespace TodoWebApp.Repository.InMemory
{
  public class InMemoryRepository
  {
    static List<Todo> todos = new List<Todo>();

    static InMemoryRepository()
    {
      todos.Add(new Todo(0, "Some Title Zero", "Some Description Zero", false, DateTime.Now));
      todos.Add(new Todo(1, "Some Title One", "Some Description One", false, DateTime.Now));
      todos.Add(new Todo(2, "Some Title Two", "Some Description Two", false, DateTime.Now));
    }

    public List<Todo> GetAllTodos()
    {
      return todos;
    }

    public Todo? GetTodoById(int id)
    {
      return todos.FirstOrDefault((todo) => todo.Id == id);
    }

    public Todo AddTodo(Todo newTodo)
    {
      newTodo.Id = newTodo.Id = todos[todos.Count - 1].Id + 1;
      todos.Add(newTodo);
      return newTodo;
    }

    public Todo? UpdateTodo(int todoId, Todo newTodo){
      int todoIndex = todos.FindIndex((todo) => todo.Id == todoId);
      if(todoIndex == -1) return null;
      todos[todoIndex] = newTodo;
      return newTodo;
    }

    public Todo? DeleteTodoById(int todoId)
    {
      Todo? oldTodo = todos.Find((todo) => todo.Id == todoId);
      if(oldTodo == null) return null;
      todos.Remove(oldTodo);
      return oldTodo;
    }
  }
}