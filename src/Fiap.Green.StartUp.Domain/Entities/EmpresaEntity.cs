using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("EMPRESA")]
    [JsonObject("empresa")]
    public class EmpresaEntity
    {
        [Key]
        [Column("IDEMPRESA")]
        [JsonProperty("idEmpresa")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        [Column("NMEMPRESA")]
        [JsonProperty("nomeEmpresa")]
        public string NomeEmpresa { get; set; }

        [Column("RAZAOSOCIAL")]
        [JsonProperty("razaoSocial")]
        public string RazaoSocial { get; set; }

        [Column("CNPJ")]
        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }

        [Column("SEGEMPRESA")]
        [JsonProperty("segmentoEmpresa")]
        public string SegmentoEmpresa { get; set; }

        [Column("PGREEN")]
        [JsonProperty("programaGreen")]
        public string ProgramaGreen { get; set; }
    }
}