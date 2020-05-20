using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Models;
using APIDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormValidationDemo : ControllerBase
    {
        
        private readonly ILogger<FormValidationDemo> _logger;

        public FormValidationDemo(ILogger<FormValidationDemo> logger)
        {
            _logger = logger;
        }

       
        [HttpPost]
        public IActionResult Post([FromForm]FormModel formModel) {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                GeneralService generalService = new GeneralService();
                 formModel = generalService.ReverseFormField(formModel);
            }

            return Ok(formModel);
        }
    }
}
