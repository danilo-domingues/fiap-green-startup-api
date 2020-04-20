using System;
using System.Net;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Services.UsuarioServices;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Green.StartUp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : BaseController
    {

        private readonly IUsuarioServices IUsuarioServices;

        public UsuarioController(IUsuarioServices IUsuarioServices)
        {
            this.IUsuarioServices = IUsuarioServices;
        }


        [HttpGet]
        [Route("UsuarioLogin/{username}/{password}")]
        public IActionResult UsuarioLogin(string username, string password)
        {

            try
            {
                var result = IUsuarioServices.UsuarioLogin(username, password);
                return ResponseOk(result);
            }
            catch (Exception)
            {

                return BadRequest(new
                {
                    sucess = false,
                    errors = new[] { "ocorreu um erro no servidor." }
                });

            }
        }
    }
}