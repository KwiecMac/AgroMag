using AgroMagBusinessLogic.Field.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroMagAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class FieldController : ControllerBase
    {
        private readonly IFieldService fieldService;

        public FieldController(IFieldService fieldService)
        {
            this.fieldService = fieldService;
        }

        [HttpPost(nameof(CreateField))]
        public async Task<IActionResult> CreateField()
        {
            AgroMagDatabase.Models.Field.Field field = new();
            field.Area = 10;
            field.Name = "SomeField";

            await fieldService.CreateFieldAsync(field);

            return Ok();
        }
    }
}
