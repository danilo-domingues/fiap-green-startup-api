using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("CLIENTE")]
    [JsonObject("cliente")]
    public class ClienteEntity
    {
        [JsonProperty("idCliente")]
        [Key]
        [Column("IDCLIENTE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [JsonProperty("ultimaCompra")]
        [Column("ULTIMACOMPRA")]
        public string UltimaCompra { get; set; }

        [JsonProperty("pontos")]
        [Column("PONTOS")]
        public string Pontos { get; set; }

        [JsonProperty("quantidadeCompra")]
        [Column("QUANTIDADECOMPRA")]
        public string QuantidadeCompra { get; set; }

        [JsonProperty("idTipoCliente")]
        [Column("TIPOCLIENTE")]
        public int TipoCliente { get; set; }

        [JsonProperty("dadosAdd")]
        [Column("DADOSADD")]
        public string DadosAdicionais { get; set; }
    }
}