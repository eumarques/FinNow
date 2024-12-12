using Microsoft.AspNetCore.Mvc;

namespace FinNow.API.Controllers
{
    [ApiController]
    [Route("api/saida")]
    public class SaidaController : ControllerBase
    {

        [HttpPost]
        public IActionResult AdicionarSaida()
        {
            return NoContent();
        }

        [HttpGet]
        public IActionResult BuscarTodasSaidas()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarSaidaPorId(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult EditarSaida(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSaida(int id)
        {
            return Ok();
        }
    }
}
