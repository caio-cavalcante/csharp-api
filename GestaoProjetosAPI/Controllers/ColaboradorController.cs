using Microsoft.AspNetCore.Mvc;
using GestaoProjetosAPI.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace GestaoProjetosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        private readonly string _connectionString;

        public ColaboradorController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT 
                        C.Id, 
                        C.Nome, 
                        C.Cargo, 
                        C.Salario, 
                        C.ProjetoId,
                        P.Nome as NomeProjeto
                    FROM Colaboradores C
                    INNER JOIN Projetos P ON C.ProjetoId = P.Id";

                // dapper executa o SQL e transforma em lista
                var dados = await connection.QueryAsync<Colaborador>(sql);

                return Ok(dados);
            }
        }
    }
}