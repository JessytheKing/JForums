﻿using System;

namespace JForums.Models.Reply
{
    public class PostReply
    {
        //Create Admin Link reply to Post and Forum
        public int Id { get; set; }

        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorRating { get; set; }
        //public bool IsAuthorAdmin { get; set; }

        public DateTime Date { get; set; }
        public string ReplyContent { get; set; }

        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

        //public string ForumName { get; set; }
        //public string ForumImageUrl { get; set; }
        //public int ForumId { get; set; }
    }
}
