using Fiap.Green.StartUp.Domain.DataAccess.ConnectionOracle;
using Fiap.Green.StartUp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;

namespace Fiap.Green.StartUp.Domain.DataAccess.GreenContext
{
    public class ConextDB : DbContext
    {


        private readonly OracleConfiguration configuration;

        private string connectionString = "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = oracle.fiap.com.br)(PORT = 1521)))(CONNECT_DATA = (SID = orcl)));Persist Security Info=True;User ID=RM81792;Password=021293;Pooling=True;Connection Timeout=60;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.HasDefaultSchema("RM81792");

        public DbSet<PessoaEntity> PessoaMap { get; set; }
        public DbSet<UsuarioEntity> UsuarioMap { get; set; }
        public DbSet<CompraEntity> CompraMap { get; set; }

        public DbSet<EmpresaEntity> EmpresaMap { get; set; }

        public DbSet<FornecedorEntity> FornecedorMap { get; set; }

        public DbSet<ProdutoEntity> ProdutoMap { get; set; }

        public DbSet<TipoPagamentoEntity> TipoPagamentoMap { get; set; }
         public DbSet<TipoProdutoEntity> TipoProdutoMap { get; set; }

        public DbSet<ClienteEntity> ClientMap { get; set; }
    }
}