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
    public class PostServices : IPost
    {
        private readonly ApplicationDbContext _context;

        public PostServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SPost> GetLatestPosts(int n)
        {
           return GetAll().OrderByDescending(post => post.Created).Take(n); 
        }

        public async Task Add(SPost post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();

        }

        public async Task AddReply(SPostReply reply)
        {
            _context.PostReplies.Add(reply);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var post = GetById(id);
            _context.Remove(post);
            await _context.SaveChangesAsync();

        }

        //public async Task Archive(int id)
        //{
        //    var post = GetById(id);
        //    post.IsArchive = true;
        //    _context.Update(post);
        //    await _context.SaveChangesAsync();
        //}

        public async Task EditPostContent(int id, string content)
        {
            var post = GetById(id);
            post.Content = content;
            _context.Post.Update(post);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<SPost> GetAll()
        {
            var posts = _context.Post
                .Include(post => post.Forums)
                .Include(post => post.User)
                .Include(post => post.Replies)
                .ThenInclude(reply => reply.User);
            return posts; 

        }

        public IEnumerable<SPost> GetAllUsers(IEnumerable<SPost> posts)
        {
            throw new NotImplementedException();
        }

        public SPost GetById(int id)
        {
            return _context.Post.Where(post => post.Id == id)
                .Include(post => post.Forums)
                .Include(post => post.User)
                .Include(post => post.Replies)
                .ThenInclude(reply => reply.User)
                .FirstOrDefault(); 


        }

        public IEnumerable<SPost> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

      

        public IEnumerable<SPost> GetPostByForum(int id)
        {
            return _context.Forums
                .Where(forum => forum.Id == id).First().Post;
        }

        public IEnumerable<SPost> GetPostsByForum(int id)
        {
            throw new NotImplementedException();
        }
    }
}
