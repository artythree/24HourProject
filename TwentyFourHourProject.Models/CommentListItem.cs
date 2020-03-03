using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Data;

namespace TwentyFourHourProject.Models
{
    public class CommentListItem
    {
        public string Text { get; set; }
        public Guid Author { get; set; }
        public Post CommentPost { get; set; }
    }
}
