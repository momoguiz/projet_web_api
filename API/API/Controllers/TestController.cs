using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    /// <summary>
    /// Controlleur de test
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        ///  Action pour dire bonjour 
        /// </summary>
        /// <param name="nom"> Nom à qui dire bonjour </param>
        /// <returns> Retourne Bonjour suivi du nom de la peersonne </returns>
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
