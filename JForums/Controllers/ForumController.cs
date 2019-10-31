using System.Linq;
using JForums.Interface;
using JForums.Models.Forums;
using JForums.Models.Post;
using JForums.SharedModels;
using Microsoft.AspNetCore.Mvc;

namespace JForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;

        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListing
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description
            });
            var model = new ForumIndex
            {
                ForumList = forums
            };
            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = forum.Post;

            var postListing = posts.Select(post => new PostListing
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                Title = post.Title,
                DatedPosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)

            });

            var model = new ForumTopic
            {
                Posts = postListing,
                Forum = BuildForumListing(forum)

            };

            return View(model);
        }

        private ForumListing BuildForumListing(SPost post)
        {
                var forum = post.Forums;
                return BuildForumListing(forum);
        }

        //Change Name of EntitiesModel 
        private ForumListing BuildForumListing(SharedModels.Forums forum)
        {

            return new ForumListing
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl

            };
        }
    }
}