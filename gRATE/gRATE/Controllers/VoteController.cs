using gRATE.Data;
using gRATE.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private IRepository _repository;

        public VoteController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Post(VoteViewModel vote)
        {
            return Ok();
        }
    }
}