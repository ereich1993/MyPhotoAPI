using gRATE.Data;
using gRATE.Models;
using gRATE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace gRATE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private IRepository _repository;
        private IConfiguration _configuration;

        public VoteController(IRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Post(VoteViewModel voteVM)
        {
            if (voteVM.VoteValue <= _configuration.GetSection("Constants").GetValue<int>("MaxVote"))
            {
                bool isSaved = _repository.PutVote(voteVM).Result;
                if (isSaved) return Ok();
                return BadRequest();
            }
            return BadRequest();
        }
    }
}