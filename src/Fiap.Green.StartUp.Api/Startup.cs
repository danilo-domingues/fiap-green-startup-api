
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Green.StartUp.DataAccess.ConnectionOracle;
using Fiap.Green.StartUp.Domain.DataAccess.GreenContext;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.DataAccess.Repository;
using Fiap.Green.StartUp.Domain.Services.UsuarioServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Fiap.Green.StartUp.Api.Configuration;
using Fiap.Green.StartUp.Domain.DataAccess.ConnectionOracle;

namespace Fiap.Green.StartUp.Api
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public IConfigurationRoot ConfigurationRoot{get;}

        public AppSettings AppSettings {get; set;} = new AppSettings();

        public ServiceProvider ServiceProvider {get; private set;}


        #region .: Const :.
        private const string Conf = "conf";
        private const string AppSettingsJson = "appsettings.json";
        #endregion


        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), Conf))
                                    .AddJsonFile(AppSettingsJson, optional: true, reloadOnChange: true)
                                    .AddEnvironmentVariables();

            Configuration = builder.Build();
            ConfigurationRoot = builder.Build();
            ConfigurationRoot.Bind(AppSettings);

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IConfiguration>(Configuration);

            services.AddDependencies();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
