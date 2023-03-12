namespace TodoWebApp.Models
{
  public class Todo
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime DueDate { get; set; }

    public Todo(){}

    public Todo(int id, string title, string description, bool status, DateTime dueDate)
    {
      this.Id = id;
      this.Title = title;
      this.Description = description;
      this.Status = status;
      this.DueDate = dueDate;
    }
  }
}