using System.Collections.Generic;
using JForums.Models.Post;

namespace JForums.Models.Home
{
    public class HomeIndex
    {
        public string SearchQuery { get; set; }
        public IEnumerable<PostListing> LatestPosts { get; set; }
    }
}
