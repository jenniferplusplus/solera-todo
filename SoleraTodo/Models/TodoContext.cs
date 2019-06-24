using Microsoft.EntityFrameworkCore;

namespace SoleraTodo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public TodoContext()
        {
        }

        public DbSet<Todo> TodoItems { get; set; }
    }
}