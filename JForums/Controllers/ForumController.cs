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
                .Select(forum => new ForumsListing
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
            var posts = forum.Posts;

            var postListing = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                Title = post.Title,
                DatePosted = post.Create.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)

            });

            var model = new ForumTopic
            {
                Post = postListing,
                Forum = BuildForumListing(forum)

            };

            return View(model);
        }

        private ForumsListing BuildForumListing(Post post)
        {
                var forum = post.Forums;
                return BuildForumListing(forum);
        }

        //Change Name of EntitiesModel 
        private ForumsListing BuildForumListing(SharedModels.Forums forum)
        {

            return new ForumsListing
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl

            };
        }
    }
}