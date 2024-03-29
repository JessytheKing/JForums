﻿using System;
using System.Collections.Generic;

namespace JForums.SharedModels
{
    public class Forums
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<SPost> Post { get; set; }
    }
}
