using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Green.StartUp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TesteAzure : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAction()
        {
             return Ok(
                 new
                 {
                     statusCode = HttpStatusCode.OK,
                     header = new
                     {
                         data = 200
                     },
                 });
        }
    }
}
