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
        public IActionResult GetAll()
        {
            var allResults = _repository.GetAll();
            return new OkObjectResult(allResults);
        }
        
        [Route("/api/[controller]/{id}")]
        public IActionResult GetOne(int id)
        {
            var result = _repository.GetById(id);
            return new OkObjectResult(result);
        }

        [HttpPost]
        [Route("/api/[controller]")]
        public IActionResult Create([FromBody]Todo todo)
        {
            var result = _repository.Add(todo);
            return new OkObjectResult(result);
        }
    }
}