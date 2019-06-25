using System;
using System.ComponentModel.DataAnnotations;

namespace SoleraTodo.Models
{
    public class Todo
    {
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int TodoId { get; set; }
    }
}