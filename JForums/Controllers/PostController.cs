using System;
using System.Collections.Generic;
using System.Linq;
using JForums.Interface;
using JForums.Models.Post;
using JForums.Models.Reply;
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
            var replies = BuildPostReplies(post.Replies);
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
                Replies = replies
            };
            return View(model);
        }

        private IEnumerable<PostReply> BuildPostReplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(reply => new PostReply()
            {
                ryryrryyr
            });
        }
    }
}