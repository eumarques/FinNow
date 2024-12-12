using FinNow.API.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace FinNow.API.Controllers
{
    [ApiController]
    [Route("api/receitas")]
    public class ReceitaController : ControllerBase
    {
        public ReceitaController()
        {
        }

        [HttpPost]
        public IActionResult AdicionarReceita(ReceitaInputModel receitaInput) 
        { 
            return NoContent();
        }

        [HttpGet]
        public IActionResult BuscarPorTodasReceitas()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarReceitaPorId(int id)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult EditarReceita(int id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletarReceita(int id)
        {
            return Ok();
        }
    }
}
