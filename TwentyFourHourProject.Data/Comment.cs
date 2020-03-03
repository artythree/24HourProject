using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHourProject.Data
{
    public class Comment
    {
        // Body of comment
        public string Text { get; set; }


        // Who is writing the comment
        public Guid Author { get; set; }


        // CommentPost is which post we're commenting on
        public Post CommentPost { get; set; }
    }
}
