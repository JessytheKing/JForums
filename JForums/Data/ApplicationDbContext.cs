using JForums.SharedModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JForums.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Forums> Forums { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }

        //Working
        //public DbSet<PrivateMessage> PrivateMessages { get; set; }

    }
}
