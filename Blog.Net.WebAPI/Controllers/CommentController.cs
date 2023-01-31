using Blog.Net.Entities.Concrete;
using Blog.Net.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Net.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentServices _commentServices;
        public CommentController(ICommentServices commentServices)
        {
            _commentServices = commentServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _commentServices.GetAll();
            if (result.Count <= 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpGet("GetByPostId")]
        public IActionResult Get(string postId)
        {
            var result = _commentServices.GetByPostId(postId);

            return Ok(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(Comment comment)
        {         
            var result = _commentServices.Add(comment);
            
            return Ok(result);
        }
    }
}
