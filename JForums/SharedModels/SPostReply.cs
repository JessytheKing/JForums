using System;

namespace JForums.SharedModels
{
    public class SPostReply
    {

        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual SPost Post { get; set; }
    }
}
