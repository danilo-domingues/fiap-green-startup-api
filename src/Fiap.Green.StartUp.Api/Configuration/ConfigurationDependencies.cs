using System.Runtime.CompilerServices;
using System.Data.Common;
using Fiap.Green.StartUp.Domain.DataAccess.GreenContext;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.DataAccess.Repository;
using Fiap.Green.StartUp.Domain.Services.PessoaServices;
using Fiap.Green.StartUp.Domain.Services.UsuarioServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Fiap.Green.StartUp.Domain.Services.CompraServices;

namespace Fiap.Green.StartUp.Api.Configuration
{


    public static class ConfigurationDependencies
    {

        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ConextDB>();
            services.AddTransient<IPessoaRepository, PessoaRepository>();
            services.AddTransient<IPessoaServices, PessoaServices>();

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioServices, UsuarioServices>();

            services.AddTransient<ICompraRepository, CompraRepository>();
            services.AddTransient<ICompraServices, CompraServices>();


            return services;
        }
    }
}