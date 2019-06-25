using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoleraTodo.Models
{
    public interface ITodoRepository
    {
        Todo GetById(int id);
        IEnumerable<Todo> GetAll();
        Task<Todo> Add(Todo todo);
        void Update(Todo todo);
    }
}