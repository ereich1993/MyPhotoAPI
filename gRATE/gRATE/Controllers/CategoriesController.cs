using gRATE.Data;
using Microsoft.AspNetCore.Mvc;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private IRepository _repository;

        public CategoriesController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCategories());
        }
    }
}