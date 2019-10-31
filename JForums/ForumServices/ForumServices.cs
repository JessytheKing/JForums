using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JForums.Data;
using JForums.Interface;
using JForums.SharedModels;
using Microsoft.EntityFrameworkCore;

namespace JForums.ForumServices
{
    public class ForumServices : IForum
    {
        private readonly ApplicationDbContext _context;
        private readonly IPost _postService;

        public ForumServices(ApplicationDbContext context, IPost postService)
        {
            _context = context;
            _postService = postService;
        }

        public async Task Create(Forums forum)
        {
            _context.Add(forum);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var forum = GetById(id);
            _context.Remove(forum);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<SApplicationUser> GetActiveUsers(int forumId)
        {
            var posts = GetById(forumId).Post;

            if (posts == null || !posts.Any())
            {
                return new List<SApplicationUser>();
            }

            return _postService.GetAllUsers(posts);
        }

        public IEnumerable<Forums> GetAll()
        {
            return _context.Forums
                .Include(forums => forums.Post); 
        }

        public Forums GetById(int id)
        {
            var forum = _context.Forums
                .Where(f => f.Id == id)
                .Include(f => f.Post)
                .ThenInclude(f => f.User)
                .Include(f => f.Post)
                .ThenInclude(f => f.Replies)
                .ThenInclude(f => f.User)
                .Include(f => f.Post)
                .ThenInclude(p => p.Forums)
                .FirstOrDefault();

            if (forum.Post == null)
            {
                forum.Post = new List<SPost>(); 
            }

            return forum; 
        }

        public SPost GetLastestPost(int forumId)
        {
            var posts = GetById(forumId).Post;

            if (posts != null)
            {
                return GetById(forumId).Post
                    .OrderByDescending(post => post.Created)
                    .FirstOrDefault(); 
            }
            return new SPost();
        }

        public bool HasRecentPost(int id)
        {
            const int hoursAgo = 12;
            var window = DateTime.Now.AddHours(-hoursAgo);
            return GetById(id).Post.Any(post => post.Created >= window);
        }

        public async Task Add(Forums forum)
        {
            _context.Add(forum);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<SPost> GetFilterPosts(string searchQuery)
        {
            return _postService.GetFilteredPosts(searchQuery);
        }

        public async Task SetForumImage(int id, Uri uri)
        {
            var forum = GetById(id);
            forum.ImageUrl = uri.AbsoluteUri;
            _context.Update(forum);
            await _context.SaveChangesAsync(); 
        }

        public IEnumerable<SPost> GetFilterPosts(int forumId, string searchQuery)
        {
            if (forumId == 0)
            {
                return _postService.GetFilteredPosts(searchQuery);
            }

            var forum = GetById(forumId);
            return string.IsNullOrEmpty(searchQuery)
                ? forum.Post
                : forum.Post.Where(post => post.Title.Contains(searchQuery) || post.Content.Contains(searchQuery)); 
        }

        public async Task UpdateForumDescription(int id, string description)
        {
            var forum = GetById(id);
            forum.Description = description;

            _context.Update(forum);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateForumsTitle(int id, string title)
        {
            var forum = GetById(id);
            forum.Title = title;

            _context.Update(forum);
            await _context.SaveChangesAsync();

        }
    }

}
