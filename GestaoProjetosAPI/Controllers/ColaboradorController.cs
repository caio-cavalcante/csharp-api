using Microsoft.AspNetCore.Mvc;
using GestaoProjetosAPI.Models;

namespace GestaoProjetosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = new List<Colaborador>
            {
                new Colaborador { Id = 1, Nome = "Teste", Cargo = "Dev", Salario = 1000, ProjetoId = 1 }
            };

            return Ok(lista); 
        }
    }
}