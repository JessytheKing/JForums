using JForums.SharedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JForums.Interface
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllUsers(IEnumerable<Post> posts);
        IEnumerable<Post> GetPostsByForum(int id);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        Task AddReply(PostReply reply);

    }
}
