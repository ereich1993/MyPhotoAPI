using gRATE.Data;
using gRATE.Models;
using Microsoft.AspNetCore.Mvc;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IRepository _repository;

        public ImageController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get(Category category = Category.All)
        {
            return Ok(new Image());
        }
    }
}