using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("TIPOPAGAMENTO")]
    [JsonObject("tipoPagamento")]
    public class TipoPagamentoEntity
    {
        [Key]
        [Column("IDTIPOPAGAMENTO")]
        [JsonProperty("idTipoPagamento")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoPagamento { get; set; }

        [Column("DESCRICAO")]
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
    }
}