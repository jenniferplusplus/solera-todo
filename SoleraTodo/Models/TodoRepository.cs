using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoleraTodo.Models
{
    public class TodoRepository : IDisposable, ITodoRepository
    {
        private TodoContext db;

        public TodoRepository(TodoContext db)
        {
            this.db = db;
        }

        public static TodoRepository Create(IServiceProvider service)
        {
            return new TodoRepository(service.GetService(typeof(TodoContext)) as TodoContext);
        }

        public Todo GetById(int id)
        {
            return db.TodoItems.FirstOrDefault(x => x.TodoId == id);
        }

        public IEnumerable<Todo> GetAll()
        {
            return db.TodoItems.Where(x => true);
        }

        public async Task<Todo> Add(Todo todo)
        {
            var result = db.TodoItems.Add(todo);
            await db.SaveChangesAsync();
            
            return result.Entity;
        }

        public void Update(Todo todo)
        {
            db.TodoItems.Update(todo);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db?.Dispose();
        }

        public void Dispose(bool isDisposing)
        {
            if(isDisposing) Dispose();
        }
    }
}