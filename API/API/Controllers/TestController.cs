using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Bonjour/{nom}")]
        public IActionResult Get(string nom)
        {
            if(String.IsNullOrEmpty(nom))
            {
                return BadRequest();
            }
            return Ok($"Bonjour {nom} !");
        }
    }
}
