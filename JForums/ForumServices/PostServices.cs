using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JForums.Data;
using JForums.Interface;
using JForums.SharedModels;

namespace JForums.ForumServices
{
    public class PostServices : IPost
    {
        private readonly ApplicationDbContext _context;

        public PostServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SPost> GetPostByForum(int id)
        {
            return _context.Forums
                .Where(forum => forum.Id == id).First().Post;
        }
    }
}
