using System.Collections.Generic;
using System.Threading.Tasks;
using JForums.SharedModels;


namespace JForums.Interface
{
    public interface IForum
    {
        SharedModels.Forums GetById(int id);
        IEnumerable<SharedModels.Forums> GetAll();
        IEnumerable<SApplicationUser> GetApplicationUsers();

        Task Create(SharedModels.Forums forum);
        Task Delete(int id);
        Task UpdateForumsTitle(int id, string NewTitle);
        Task UpdateForumDescription(int forumId, string newDescription);

    }
}
