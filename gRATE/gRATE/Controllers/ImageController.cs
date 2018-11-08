using gRATE.Data;
using gRATE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IRepository _repository;

        //ctor
        public ImageController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(Category category = Category.All)
        {
            Image image = await _repository.GetAnImage(category);

            if (image != null) return Ok(image);

            return NotFound();
        }
    }
}