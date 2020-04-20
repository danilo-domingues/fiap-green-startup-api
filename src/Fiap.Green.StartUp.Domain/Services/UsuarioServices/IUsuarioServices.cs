using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.UsuarioServices
{
    public interface IUsuarioServices
    {
        LoginEntity UsuarioLogin(string username, string password);
    }
}