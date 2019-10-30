using System.Collections.Generic;
using JForums.Models.Post;

namespace JForums.Models.Forums
{
    public class ForumTopic
    {

        public ForumListing Forum { get; set; }
        public IEnumerable<PostListing> Posts { get; set; }

    }
}
