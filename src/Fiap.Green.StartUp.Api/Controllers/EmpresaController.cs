using Fiap.Green.StartUp.Domain.Entities;
using Fiap.Green.StartUp.Domain.Services.EmpresaServices;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Green.StartUp.Api.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class EmpresaController : BaseController
    {

        private readonly IEmpresaServices empresaServices;

        public EmpresaController(IEmpresaServices empresaServices)
        {
            this.empresaServices = empresaServices;
        }

        [HttpPost]
        [Route("CadastrarEmpresa")]
        public IActionResult ConsultaCompraId(EmpresaEntity empresa)
        {

            var result = empresaServices.CadastrarEmpresa(empresa);
            return ResponseOk(result);

        }

        [HttpGet]
        [Route("GetEmpresaForId/{idEmpresa}")]
        public IActionResult ConsultaCompraId(int idEmpresa)
        {

            var result = empresaServices.GetEmpresaForId(idEmpresa);
            return ResponseOk(result);

        }

        [HttpGet]
        [Route("Empresas")]
        public IActionResult ConsultaCompraId()
        {

            var result = empresaServices.ListarEmpresas();
            return ResponseOk(result);

        }

    }
}