using Microsoft.AspNetCore.Mvc;

namespace RestWithASP.NET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Sum()
        {
            return BadRequest("Invalid input");
        }
    }
}
