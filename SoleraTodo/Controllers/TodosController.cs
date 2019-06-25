using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoleraTodo.Models;

namespace SoleraTodo.Controllers
{
    [ApiController]
    [Route("/api/[controller]/")]
    public class TodosController : Controller
    {
        private ITodoRepository _repository;

        public TodosController(ITodoRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet("")]
        public IActionResult GetAll()
        {
            var allResults = _repository.GetAll();
            
            return new OkObjectResult(allResults);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = _repository.GetById(id);
            
            if(result == null) return new NotFoundResult();
            
            return new OkObjectResult(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody]Todo todo)
        {
            var result = await _repository.Add(todo);
            
            return new OkObjectResult(result);
        }
    }
}