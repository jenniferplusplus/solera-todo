using System;

namespace SoleraTodo.Models
{
    public class Todo
    {
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TodoId { get; set; }
    }
}