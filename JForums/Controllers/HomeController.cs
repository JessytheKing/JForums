using System.Diagnostics;
using JForums.Interface;
using Microsoft.AspNetCore.Mvc;
using JForums.Models;
using JForums.Models.Post;
using System.Linq;
using JForums.Models.Home;

namespace JForums.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;

        public HomeController(IPost postService)
        {
            _postService = postService; 
        }
        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        public HomeIndex BuildHomeIndexModel()
        {
            var latest = _postService.GetLatestPosts(10);

            var posts = latest.Select(post => new PostListing
            {
                Id = post.Id,
                Title = post.Title,
                AuthorName = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatedPosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                ForumId = post.Forums.Id
            });

            return new HomeIndex()
            {
                LatestPosts = posts
              
            };
        }

        

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

 
}
