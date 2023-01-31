using Blog.Net.Entities.Concrete;
using Blog.Net.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Net.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IPostServices _postServices;
        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _postServices.GetAll();
            if (result.Count <= 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpGet("GetbyTitle")]
        public IActionResult GetByTitle(string title)
        {
            var result = _postServices.GetByTitle(title);

            return Ok(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(Post post)
        {
            var result = _postServices.Add(post);

            return Ok(result);
        }        
    }
}
