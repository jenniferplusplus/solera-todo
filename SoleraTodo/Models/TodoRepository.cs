using System;
using System.Collections;
using System.Collections.Generic;

namespace SoleraTodo.Models
{
    public class TodoRepository : IDisposable, ITodoRepository
    {
        private TodoContext db = new TodoContext();

        public Todo GetById(int id)
        {
            throw  new NotImplementedException();
        }

        public IEnumerable<Todo> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public void Add(Todo todo)
        {}
        
        public void Update(Todo todo)
        {}

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