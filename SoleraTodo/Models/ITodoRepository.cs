using System.Collections.Generic;

namespace SoleraTodo.Models
{
    public interface ITodoRepository
    {
        Todo GetById(int id);
        IEnumerable<Todo> GetAll();
        int Add(Todo todo);
        void Update(Todo todo);
    }
}