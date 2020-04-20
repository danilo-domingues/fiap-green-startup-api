using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.DataAccess.IRepository
{
    public interface ICompraRepository
    {
        CompraEntity NovaCompra(CompraEntity compraEntity);
        List<CompraEntity> ConsultaCompra(int idCompra);
    }
}