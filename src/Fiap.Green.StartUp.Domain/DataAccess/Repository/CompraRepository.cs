using System.Collections.Generic;
using System.Linq;
using Fiap.Green.StartUp.Domain.DataAccess.GreenContext;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Green.StartUp.Domain.DataAccess.Repository
{
    public class CompraRepository : ICompraRepository
    {
        private readonly ConextDB context;

        public CompraRepository(ConextDB context)
        {
            this.context = context;
        }
        public List<CompraEntity> ConsultaCompra(int idCompra)
        {
            var result = this.context.CompraMap
            #region 
                                         //.Include(p => p.Produtos)
                                         //.Include(p => p.Produtos.TipoProduto)
                                         //.Include(e => e.Empresa)
                                         //.FirstOrDefault(c => c.IdCompra == idCompra);

                                         //.Include(c => c.Compras)
                                         //.Include(c => c.TipoProduto)
                                         //.Include(c => c.Fornecedor.Empresa)
                                         //.Where(c => c.Compras)
            #endregion
                                         .Include(c => c.Produto)
                                         .Include(c => c.Produto.TipoProduto)
                                         .Include(c => c.Produto.Fornecedor)
                                         .Include(c => c.Empresa)
                                         .Where(c => c.IdCompra == idCompra).ToList();

            return result;
        }


        public CompraEntity NovaCompra(CompraEntity compraEntity)
        {
            var inputCompra = this.context.CompraMap
                                                 .Add(compraEntity);
                                                 
            this.context.SaveChanges();

            var dadosCompra = this.context.CompraMap
                                         .Include(c => c.Produto)
                                         .Include(c => c.Produto.TipoProduto)
                                         .Include(c => c.Produto.Fornecedor)
                                         .Include(c => c.Empresa)
                                         .Where(c => c.Ordem == compraEntity.Ordem).FirstOrDefault();

            return dadosCompra;
        }
    }
}