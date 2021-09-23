using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroMagAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FieldController : ControllerBase
    {
        public FieldController()
        {
            // TODO: Dependency injection
        }

        [HttpGet]
        public IActionResult GetFieldList()
        {
            // TODO: method from service

            return this.Ok();
        }
    }
}
