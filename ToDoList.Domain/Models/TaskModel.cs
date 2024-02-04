namespace ToDoList.Domain.Models;

public class TaskModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Priority Priority { get; set; }
}