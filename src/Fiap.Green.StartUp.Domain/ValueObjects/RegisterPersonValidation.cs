using System.Runtime.CompilerServices;
using Fiap.Green.StartUp.Domain.Entities;
using FluentValidator;

namespace Fiap.Green.StartUp.Domain.ValueObjects
{
    public class RegisterPersonValidation : Notifiable
    {
        private readonly PessoaEntity pessoa;
       // public RegisterPersonValidation(PessoaEntity pessoa)
       // {
       //     this.pessoa = pessoa;
       //     new ValidationContract<PessoaEntity>(pessoa)
       //        .IsNotNull(pessoa.NomePessoa, "Nome e obrigatorio");
       // }
    }
}