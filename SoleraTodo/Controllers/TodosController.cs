using Microsoft.AspNetCore.Mvc;
using SoleraTodo.Models;

namespace SoleraTodo.Controllers
{
    public class TodosController : Controller
    {
        private ITodoRepository _repository;

        public TodosController(ITodoRepository repository)
        {
            _repository = repository;
        }
        
        // GET
        [Route("/api/[controller]")]
        public IActionResult Index()
        {
            return new OkObjectResult("You've reached the end of the internet. There is nothing more to see.");
        }
    }
}