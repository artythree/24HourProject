using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHourProject.Data
{
    public class Reply : Comment 
    {
        [Key]
        public int ReplyId { get; set; }

        public Guid Author;


        public Comment ReplyComment { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
