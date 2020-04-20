using System.Net.Http.Headers;
using System.Linq;
using Fiap.Green.StartUp.Domain.DataAccess.GreenContext;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Green.StartUp.Domain.DataAccess.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly ConextDB context;

        public UsuarioRepository(ConextDB context)
        {
            this.context = context;
        }
        public UsuarioEntity UsuarioLogin(string username, string password)
        {
            var usuario = context.UsuarioMap
                                    .Where(u => u.Username == username && u.Senha == password && u.Ativo == "1")
                                    .FirstOrDefault();

            return usuario;
        }
    }
}