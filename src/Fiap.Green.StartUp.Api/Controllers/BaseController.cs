using System.Xml.Linq;
using FluentValidator;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace Fiap.Green.StartUp.Api.Controllers
{
    public class BaseController : Controller
    {
        public new IActionResult Response(object Result, [FromQuery]IEnumerable<Notification> notifications)
        {

                try
                {
                    return Ok(
                 new
                 {
                     statusCode = HttpStatusCode.OK,
                     header = new
                     {
                         data = Result
                     },
                 });
                }
                catch
                {
                    
                    return BadRequest(new
                    {
                        sucess = false,
                         statusCode = HttpStatusCode.BadRequest,
                        errors = new[] { "ocorreu um erro no servidor." }
                    });
                }

        }

        public IActionResult ResponseOk(object Result)
        {
            try
            {
                return Ok(
                    new
                    {
                        StatusCode = HttpStatusCode.OK,
                        header = new
                        {
                            data = Result
                        },
                    });
            }
            catch (System.Exception)
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