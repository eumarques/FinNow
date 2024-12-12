using Microsoft.AspNetCore.Mvc;

namespace FinNow.API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdicionarUsuario()
        {
            return NoContent();
        }

        [HttpGet]
        public IActionResult BuscarTodosUsuarios()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarUsuarioPorId(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult EditarUsuario(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            return Ok();
        }
    }
}
