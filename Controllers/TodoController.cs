using Microsoft.AspNetCore.Mvc;
using ToDoWebApi.Services;

namespace ToDoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _svc;
        public TodoController(ITodoService svc) => _svc = svc;

        [HttpGet] public IActionResult Get() => Ok(_svc.GetAll());
        [HttpPost]
        public IActionResult Post([FromBody] string item)
        {
            _svc.Add(item);
            return CreatedAtAction(nameof(Get), null);
        }
    }

}
