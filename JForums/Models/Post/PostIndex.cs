using System;
using System.Collections.Generic;
using JForums.Models.Reply;

namespace JForums.Models.Post
{
    public class PostIndex
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorRating { get; set; }
        public DateTime Created { get; set; }
        public string PostContent { get; set; }
        public int ForumId { get; set; }

        public string  ForumName { get; set; }
        public IEnumerable<PostReply> Replies { get; set; }
    }
}
