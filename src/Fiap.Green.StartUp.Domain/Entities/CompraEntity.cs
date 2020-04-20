using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("COMPRA")]
    [JsonObject("compra")]
    public class CompraEntity
    {
        [Key]
        [Column("ID")]
        [JsonProperty("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("IDCOMPRA")]
        [JsonProperty("idCompra")]
        public int IdCompra { get; set; }

        //Foreing Key
        [Column("IDTPPAGAMENTO")]
        [JsonProperty("idTipoPagamento")]
        public int IdTipoPagamento { get; set; }

        [Column("PRECO")]
        [JsonProperty("preco")]
        public string Preco { get; set; }

        [Column("ORDEM")]
        [JsonProperty("ordem")]
        public string Ordem { get; set; }

        //Foreing Key
        [Column("IDPRODUTO")]
        [JsonProperty("idProduto")]
        public int IdProduto { get; set; }

        //Foreing Key
        [Column("IDEMPRESA")]
        [JsonProperty("idEmpresa")]
        public int? IdEmpresa { get; set; }

        //Navigation Property
        public ProdutoEntity Produto { get; set; }
        //Navigation Property
        public EmpresaEntity Empresa { get; set; }

    }
}