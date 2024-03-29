﻿using System;
using Microsoft.AspNetCore.Identity;

namespace JForums.SharedModels
{
    public class SApplicationUser : IdentityUser
    {       
        public string UserDescription { get; set; }
        public string ProfileImageUrl { get; set; }
        public int Rating { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public DateTime MemberSince { get; set; }
    }
}
