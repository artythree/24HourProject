using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHour.Data
{
    public class Like
    {
        public Post LikedPost { get; set; }
        public ApplicationUser Liker { get; set; }
    }
}
