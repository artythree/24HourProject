﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHourProject.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        
        [Required]
        public Guid Author { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        //public ApplicationUser Author { get; set; }
    }
}
