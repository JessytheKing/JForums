using System;
using Microsoft.AspNetCore.Http;

namespace JForums.Models.User
{
    public class Profile
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string UserRating { get; set; }
        public string ProfileImageUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        public DateTime DateJoined { get; set; }
        
        public IFormFile ImageUpload { get; set; }
    }
}
