using JForums.Interface;
using JForums.Models.Post;
using Microsoft.AspNetCore.Mvc;

namespace JForums.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;

        public PostController(IPost postService)
        {
            _postService = postService; 
        }
        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);
            var model = new PostIndex{};
            return View(model);
        }
    }
}