using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHourProject.Data
{
    public class Like
    {
        public Post LikedPost { get; set; }
        public Guid Author { get; set; }

        public bool Liked { get; set; }
    }
}
