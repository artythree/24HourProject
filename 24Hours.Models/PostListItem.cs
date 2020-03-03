using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class PostListItem
    {
        // How posts will be displayed by GetPosts()
        public int PostId { get; set; }
        public string Title { get; set; }
        //EAC: ask Sean to consider adding: [Display(Name="Created")] public DateTimeOffset CreatedUtc { get; set }
    }
}
