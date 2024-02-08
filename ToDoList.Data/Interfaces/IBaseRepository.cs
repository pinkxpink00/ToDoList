using System.Diagnostics;

namespace ToDoList.Data.Interfaces;

public interface IBaseRepository<T>
{
    Task Create(T entity);
    IQueryable<T> GetAll();
    Task Delete(T entity);
}