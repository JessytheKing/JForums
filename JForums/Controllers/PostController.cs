using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JForums.Interface;
using JForums.Models.Post;
using JForums.Models.Reply;
using JForums.SharedModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JForums.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;

        private static UserManager<ApplicationUser> _userManager;

        public PostController(IPost postService, IForum forumService, UserManager<ApplicationUser> userManager)
        {
            _postService = postService;
            _forumService = forumService;
            _userManager = userManager; 

        }
        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);
           // var replies = GetPostReplies(post).OrderBy (postReply => postReply.Date);
           
            var model = new PostIndex
            {
                Id= post.Id,
                Title = post.Title,
                AuthorId =  post.User.Id,
                AuthorName = post.User.UserName,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorRating = post.User.Rating,
                Created = post.Created,
                PostContent = post.Content,
                //Replies = replies
            };
            return View(model);
        }

       

        public IActionResult Create(int id)
        {
            //Note ID is Forum.ID
            var forum = _forumService.GetById(id);

            var model = new NewPost
            {
                ForumName = forum.Title,
                ForumID = forum.Id,
                ForumImageUrl = forum.ImageUrl,
                // Identity grants me access to User where i can get the Name from User
                AuthorName = User.Identity.Name

            };
            return View(model);

        }

        [HttpPost]
        //get tiggered everytime there is a Post
        // takes info in form of view model get pushed into database
        //public async Task<IActionResult> AddPost(NewPost model)
        //{
        //    var userId = _userManager.GetUserId(User);
        //    //blocks till it becomes open
        //    var user = await _userManager.FindByIdAsync(userId);
        //
        //    var post = BuildPost(model, user);
        //
        //    await _postService.Add(post);
        //
        //
        //    //TODO: User rating 
        //    return RedirectToAction("Index", "Forum", model.ForumID); 
        //
        //}

        private SPost BuildPost(NewPost model, ApplicationUser user)
        {
            var now = DateTime.Now; 
            var forum = _forumService.GetById(model.ForumID); 

            return new SPost
            {
                Title = model.Title,
                Content = model.Content,
                Created = now,
                User = user,
                Forums = forum
            };
        }


        private IEnumerable<PostReply> BuildPostReplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(reply => new PostReply()
            {
                Id = reply.Id,
                AuthorName = reply.User.UserName,
                AuthorId = reply.User.Id,
                AuthorImageUrl = reply.User.ProfileImageUrl,
                AuthorRating = reply.User.Rating,
                Date = reply.Created,

            });
        }
    }
}