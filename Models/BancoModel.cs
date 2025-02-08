namespace webApi.Models
{
    public class BancoModel
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Codigo { get; set; }
        public bool Ativo { get; set; }

        public List<ContaModel> Contas { get; set; }
    }
}