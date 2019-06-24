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
            var getAll = _repository.GetAll();
            return new OkObjectResult(getAll);
        }
        
        [Route("/api/[controller]/[id]")]
        public IActionResult Index()
        {
            var getAll = _repository.GetAll();
            return new OkObjectResult(getAll);
        }
    }
}