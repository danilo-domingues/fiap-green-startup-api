using System;
using Fiap.Green.StartUp.Domain.Entities;
using Fiap.Green.StartUp.Domain.Services.CompraServices;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Green.StartUp.Api.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class CompraController : BaseController
    {
        private readonly ICompraServices compraServices;
        public CompraController(ICompraServices compraServices)
        {
            this.compraServices = compraServices;
        }

        [HttpGet]
        [Route("ConsultaCompra/{idCompra}")]
        public IActionResult ConsultaCompraId(int idCompra)
        {
            try
            {
                var result = compraServices.ConsultaCompraId(idCompra);
                return ResponseOk(result);
            }
            catch (Exception ex)
            {

                return BadRequest(new
                {
                    sucess = false,
                    errors = new[] { "ocorreu um erro no servidor.", ex.Message }
                });
            }
        }


        [HttpPost]
        [Route("NovaCompra")]
        public IActionResult NovaCompra(CompraEntity compra)
        {
            try
            {
                var result = compraServices.ConfirmaCompra(compra);
                return ResponseOk(result);
            }
            catch (Exception ex)
            {

                return BadRequest(new
                {
                    sucess = false,
                    errors = new[] { "ocorreu um erro no servidor.", ex.Message }
                });
            }
        }

    }
}