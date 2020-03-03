using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHour.Data
{
    public class Reply : Comment 
    {
        public Guid OwnerId;

        public Comment ReplyComment { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
