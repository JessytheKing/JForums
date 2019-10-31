using JForums.SharedModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JForums.Data
{
    public class ApplicationDbContext : IdentityDbContext<SApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Forums> Forums { get; set; }
        public DbSet<SPost> Post { get; set; }
        public DbSet<SPostReply> PostReplies { get; set; }

        //Working
        //public DbSet<PrivateMessage> PrivateMessages { get; set; }

    }
}
