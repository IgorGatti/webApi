namespace webApi.Models
{
    public class FormaPagamentoModel
    {
        public int Id { get; set; }
        public required string Descricao { get; set; }
        public bool Ativo { get; set; }

        public List<ContaModel> Contas { get; set; }
    }
}