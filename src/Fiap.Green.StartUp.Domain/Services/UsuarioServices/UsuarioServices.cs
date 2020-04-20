using System;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.UsuarioServices
{
    public class UsuarioServices : IUsuarioServices
    {


        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        public LoginEntity UsuarioLogin(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                return null;

            var logarUsuario = usuarioRepository.UsuarioLogin(username, password);
            if (logarUsuario != null)
            {

                var retornoAutorizado = new LoginEntity
                {
                    Username = logarUsuario.Username,
                    Ativo = logarUsuario.Ativo,
                    Message = "Usuario Autorizado!"
                };

                return retornoAutorizado;
            }
            var retornoNaoAutorizado = new LoginEntity
            {
                Message = $"Usuario: {username} nao encontrado"
            };

            return retornoNaoAutorizado;
        }
    }
}