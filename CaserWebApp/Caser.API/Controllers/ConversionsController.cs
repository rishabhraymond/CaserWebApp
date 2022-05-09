using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caser.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionsController : ControllerBase
    {
        [HttpGet("Convert")]
        public async Task<IActionResult> Convert()
        {
            var files = HttpContext.Request.Form.Files;
            return Ok(true);
        }
    }
}
