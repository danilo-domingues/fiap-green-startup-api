using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("PRODUTO")]
    [JsonObject("produto")]
    public class ProdutoEntity
    {
        [Key]
        [Column("IDPRODUTO")]
        [JsonProperty("idProduto")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        [Column("NOMEPRODUTO")]
        [JsonProperty("nomeProduto")]
        public string NomeProduto { get; set; }

        [Column("QUANTIDADE")]
        [JsonProperty("quantidade")]
        public string Quantidade { get; set; }

        [Column("ATIVO")]
        [JsonProperty("ativo")]
        public string Ativo { get; set; }

        [Column("PRECO")]
        [JsonProperty("preco")]
        public string Preco { get; set; }

        [Column("DTATUALIZACAO")]
        [JsonProperty("dtAtualizacao")]
        public string DataAtualizacao { get; set; }

        //Foreing Key
        [Column("IDTIPOPRODUTO")]
        [JsonProperty("idTipoProduto")]
        public int IdTipoProduto { get; set; }

        //Foreing Key
        [Column("IDFORNECEDOR")]
        [JsonProperty("idFornecedor")]
        public int? IdFornecedor { get; set; }

        //Navigation Property
        public TipoProdutoEntity TipoProduto { get; set; }

        //Navigation Property
        public FornecedorEntity Fornecedor { get; set; }

        //public List<CompraEntity> Compras { get; set; }
    }
}