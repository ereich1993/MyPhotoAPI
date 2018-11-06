using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("images")]
        public IActionResult GetImages()
        {
            return Ok();
        }

        [HttpGet("images/{id:int}")]
        public IActionResult GetAnImage(int imageID)
        {
            return Ok();
        }
    }
}