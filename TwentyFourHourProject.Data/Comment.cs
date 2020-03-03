using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHourProject.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        // Body of comment
        public string Text { get; set; }

        
        // Who is writing the comment
        public Guid Author { get; set; }

       
        // CommentPost is which post we're commenting on
        public Post CommentPost { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
