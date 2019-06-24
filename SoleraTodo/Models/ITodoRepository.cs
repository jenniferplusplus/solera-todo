using System.Collections.Generic;

namespace SoleraTodo.Models
{
    public interface ITodoRepository
    {
        Todo GetById(int id);
        IEnumerable<Todo> GetAll();
        void Add(Todo todo);
        void Update(Todo todo);
    }
}