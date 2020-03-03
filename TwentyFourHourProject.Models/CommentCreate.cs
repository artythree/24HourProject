using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Data;

namespace TwentyFourHourProject.Models
{
    public class CommentCreate : Comment
    {
        [MaxLength(8000)]
        public string Content { get; set; }
       
    }
}
