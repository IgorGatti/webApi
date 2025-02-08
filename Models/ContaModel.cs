using System.Data;
using System.ComponentModel.DataAnnotations;

namespace webApi.Models
{
    public class ContaModel
    {
        [Key]
        public int Id { get; set; }
        public required float Valor { get; set; }

        public required string Descricao { get; set; }

        public required DateTime Data { get; set; }

        public int Id_formapagamento { get; set; }
        public int Id_banco { get; set; }

        public required DateTime Dt_cad { get; set; } = DateTime.Now;

        public BancoModel? Bancos { get; set; }
        public FormaPagamentoModel? FormaPagamento { get; set; }

    }
}