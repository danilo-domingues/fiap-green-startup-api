using System;
using System.Collections.Generic;
using System.IO;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.CompraServices
{
    public class CompraServices : ICompraServices
    {

        private readonly ICompraRepository compraRepository;
        public CompraServices(ICompraRepository compraRepository)
        {
            this.compraRepository = compraRepository;
        }
        public CompraEntity ConfirmaCompra(CompraEntity compra)
        {
           compra.Ordem = Guid.NewGuid().ToString();
            
            var result = compraRepository.NovaCompra(compra);
            return result;
        }

        public List<CompraEntity> ConsultaCompraId(int IdCompra)
        {
            var result = compraRepository.ConsultaCompra(IdCompra);
            return result;
        }
    }
}