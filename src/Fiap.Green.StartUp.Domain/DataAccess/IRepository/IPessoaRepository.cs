using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.DataAccess.IRepository
{
    public interface IPessoaRepository
    {

        PessoaEntity GetPersonForId(int IdPessoa);

        PessoaEntity RegisterPerson(PessoaEntity pessoaEntity);
         
    }
}