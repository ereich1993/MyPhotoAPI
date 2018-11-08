using gRATE.Data;
using gRATE.Models;
using gRATE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAsync(Category category = Category.All)
        {
            return Ok(await _repository.GetAnImage(category));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ImageViewModel imageModel)
        {
            Image image = new Image
            {
                Path = imageModel.Path,
                Category = imageModel.Category,
                Description = imageModel.Description,
                DesiredVoteCount = imageModel.DesiredVoteCount,
                Owner = await _repository.GetCurrentUser(),
                Title = imageModel.Title,
                UploadedOn = DateTime.Now
            };
            var result = _repository.Add(image);
            if (result)
            {
                await _repository.SaveAll();
            }
            return Ok(result);
        }
    }
}