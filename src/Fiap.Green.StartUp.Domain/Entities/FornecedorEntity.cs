using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("FORNECEDOR")]
    [JsonObject("fornecedor")]
    public class FornecedorEntity
    {
        [Key]
        [Column("IDFORNECEDOR")]
        [JsonProperty("idFornecedor")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFornecedor { get; set; }

        [Column("CNPJ")]
        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }

        [Column("NRVENDAS")]
        [JsonProperty("nrVendas")]
        public string NrVendas { get; set; }

        [Column("IDEMPRESA")]
        [JsonProperty("idEmpresa")]
        //Foreing Key
        public int? IdEmpresa { get; set; }
        //Navigation Property
        public EmpresaEntity Empresa { get; set; }
    }
}