namespace GestaoProjetosAPI.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public int ProjetoId { get; set; }
    }
}