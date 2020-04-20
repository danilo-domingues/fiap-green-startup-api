using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("TIPOPRODUTO")]
    [JsonObject("tipoProduto")]
    public class TipoProdutoEntity
    {
        [Key]
        [Column("IDTIPOPRODUTO")]
        [JsonProperty("idTipoProduto")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoProduto { get; set; }
        
        [Column("NOMETIPOPRODUTO")]
        [JsonProperty("nomeTipoProduto")]
        public string NomeTipoProduto { get; set; }

    }

}