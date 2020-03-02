using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHour.Data
{
    public class Comment
    {
        public string Text { get; set; }
        public ApplicationUser Author { get; set; }
        public Post CommentPost { get; set; }
    }
}
