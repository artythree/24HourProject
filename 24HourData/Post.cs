using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHour.Data
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
