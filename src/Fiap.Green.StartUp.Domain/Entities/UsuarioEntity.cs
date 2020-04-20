using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidator;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("USUARIO")]
    [JsonObject("usuario")]
    public class UsuarioEntity
    {
        [JsonProperty("idUsuario")]
        [Key]
        [Column("IDUSUARIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [JsonProperty("username")]
        [Column("USERNAME")]
        public string Username { get; set; }

        [Column("SENHA")]
        [JsonProperty("senha")]
        public string Senha { get; set; }

        [Column("EMAIL")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Column("ATIVO")]
        [JsonProperty("ativo")]
        public string Ativo { get; set; }

        [Column("EMAILSECUNDARIO")]
        [JsonProperty("emailSecundario")]
        public string EmailSecundario { get; set; }
        
    }
}