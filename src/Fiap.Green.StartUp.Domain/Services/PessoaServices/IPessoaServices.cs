using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.PessoaServices
{
    public interface IPessoaServices
    {
        PessoaEntity Register (PessoaEntity pessoa);
        PessoaEntity GetForId (int idPessoa);
        PessoaEntity GetForHashId(string cpf);
    }
}