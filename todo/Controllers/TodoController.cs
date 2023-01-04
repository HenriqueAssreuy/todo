using Microsoft.AspNetCore.Mvc;

namespace todo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "";
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put() { }

        [HttpDelete]
        public void Delete() { }
    }
}
