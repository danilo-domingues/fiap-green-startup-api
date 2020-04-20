using System;
using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.CompraServices
{
    public interface ICompraServices
    {
        CompraEntity ConfirmaCompra(CompraEntity compra);

        List<CompraEntity> ConsultaCompraId(int IdCompra);
    }
}