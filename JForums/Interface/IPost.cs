using JForums.SharedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JForums.Interface
{
    public interface IPost
    {
        SPost GetById(int id);
        IEnumerable<SPost> GetAll();
        IEnumerable<SPost> GetAllUsers(IEnumerable<SPost> posts);
        IEnumerable<SPost> GetPostsByForum(int id);
        IEnumerable<SPost> GetFilteredPosts(string searchQuery);
        IEnumerable<SPost> GetLatestPosts(int n); 
        
        Task Add(SPost post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        Task AddReply(SPostReply reply);

    }
}
