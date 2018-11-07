using gRATE.Data;
using Microsoft.AspNetCore.Mvc;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IRepository _repository;

        public ProfileController(IRepository repository)
        {
            _repository = repository;
        }

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