using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using System.Linq;
using Fiap.Green.StartUp.Domain.DataAccess.GreenContext;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fiap.Green.StartUp.Domain.DataAccess.Repository
{
    public class PessoaRepository : IPessoaRepository
    {

        private readonly ConextDB context;

        public PessoaRepository(ConextDB context)
        {
            this.context = context;
        }

        public PessoaEntity RegisterPerson(PessoaEntity pessoaEntity)
        {
            var pessoa = pessoaEntity;

            this.context.PessoaMap.Add(pessoaEntity);
            this.context.SaveChanges();

            return pessoa;

        }

        public PessoaEntity GetPersonForId(int IdPessoa)
        {
            var result = this.context.PessoaMap
                                     .Include(u => u.Usuario)
                                     .Include(c => c.Cliente)
                                     .FirstOrDefault(p => p.IdPessoa == IdPessoa);

            return result;
        }
    }
}