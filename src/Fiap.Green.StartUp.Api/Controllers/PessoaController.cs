using System.Text.RegularExpressions;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Fiap.Green.StartUp.Domain.Entities;
using System.Net;
using Fiap.Green.StartUp.Domain.Services.PessoaServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using FluentValidator;

namespace Fiap.Green.StartUp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : BaseController
    {

        private readonly IPessoaServices pesssoaServices;

        public PessoaController(IPessoaServices pesssoaServices)
        {
            this.pesssoaServices = pesssoaServices;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(PessoaEntity pessoa)
        {
            try
            {
                var person = pesssoaServices.Register(pessoa);

                return Response(person, null);
            }
            catch (Exception ex)
            {
                return Response(null, new List<Notification>() { new Notification(nameof(PessoaEntity), ex.Message) });
            }

        }

        [HttpGet]
        [Route("PessoaUsuarioCliente/{id}")]
        public IActionResult GetPessoaAndUser(int id)
        {
            try
            {
                var pessoaUsuario = pesssoaServices.GetForId(id);
                return Response(pessoaUsuario, null);
            }
            catch (Exception ex)
            {

                return Response(null, new List<Notification>() { new Notification(nameof(PessoaEntity), ex.Message) });
            }

        }
    }
}