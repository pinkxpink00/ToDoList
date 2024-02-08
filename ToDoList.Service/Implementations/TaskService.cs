using ToDoList.Domain.Models;
using ToDoList.Domain.Response;
using ToDoList.Domain.ViewModels.Task;
using ToDoList.Service.Interfaces;

namespace ToDoList.Service.Implementations;

public class TaskService : ITaskService
{
    public Task<IBaseResponse<TaskModel>> Create(CreateTaskViewModel model)
    {
        throw new NotImplementedException();
    }
}