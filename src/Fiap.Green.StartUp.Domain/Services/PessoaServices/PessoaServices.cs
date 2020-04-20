using System.IO;
using System.Linq;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;
using Fiap.Green.StartUp.Domain.ValueObjects;

namespace Fiap.Green.StartUp.Domain.Services.PessoaServices
{
    public class PessoaServices : IPessoaServices
    {

        private readonly IPessoaRepository pessoaRepository;
        private readonly RegisterPersonValidation personValidation;
        public PessoaServices(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
        }

        public PessoaEntity GetForHashId(string cpf)
        {
            throw new System.NotImplementedException();
        }

        public PessoaEntity GetForId(int idPessoa)
        {
            var result = pessoaRepository.GetPersonForId(idPessoa);
            return result;
        }

        public PessoaEntity Register(PessoaEntity pessoa)
        {
            //var ContractResult = new RegisterPersonValidation(pessoa);
//
            //if (!ContractResult.Notifications.Any())
            //return pessoa;

            var registerPerson = pessoaRepository.RegisterPerson(pessoa);

            return registerPerson;
        }
    }
}