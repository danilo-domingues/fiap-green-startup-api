using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.DataAccess.IRepository
{
    public interface IUsuarioRepository
    {
        UsuarioEntity UsuarioLogin (string username, string password);
    }
}