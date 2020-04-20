using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidator;
using Newtonsoft;
using Newtonsoft.Json;

namespace Fiap.Green.StartUp.Domain.Entities
{
    [Table("PESSOA")]
    [JsonObject("pessoa")]
    public class PessoaEntity
    {
        [JsonProperty("idPessoa")]
        [Key]
        [Column("IDPESSOA")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPessoa { get; set; }

        [JsonProperty("nomePessoa")]
        [Column("NOMEPESSOA")]
        public string NomePessoa { get; set; }

        [JsonProperty("rg")]
        [Column("RG")]
        public string RG { get; set; }

        [JsonProperty("cpf")]
        [Column("CPF")]
        public string CPF { get; set; }

        [JsonProperty("dataNascimento")]
        [Column("DATANASCIMENTO")]
        public string DataNascimento { get; set; }

        [JsonProperty("uf")]
        [Column("UF")]
        public string UF { get; set; }

        [JsonProperty("cidade")]
        [Column("CIDADE")]
        public string Cidade { get; set; }

        [JsonProperty("endereco")]
        [Column("ENDERECO")]
        public string Endereco { get; set; }

        [JsonProperty("cep")]
        [Column("CEP")]
        public string CEP { get; set; }

        //Foreing Key
        [JsonProperty("idUsuario")]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }
        
        //Foreing Key
        [JsonProperty("idCliente")]
        [Column("IDCLIENTE")]
        public int IdCliente { get; set; }

        //Navigation Property
        public UsuarioEntity Usuario { get; set; }

        //Navigation Property
        public ClienteEntity Cliente { get; set; }
    }
}