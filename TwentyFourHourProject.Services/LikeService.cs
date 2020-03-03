using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Data;
using TwentyFourHourProject.Models;

namespace TwentyFourHourProject.Services
{
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        
        public bool CreateLike(LikeCreate model)
        {
            var entity = new Like()
            {
                Author = _userId,
                LikedPost = model.LikedPost,
                Liked = model.Liked
            };

            using (var context = new ApplicationDbContext())
            {
                context.Likes.Add(entity);
                return context.SaveChanges() == 1;
            }
        }

        // GetPosts()
        public IEnumerable<LikeListItem> GetLikes()
        {
            using (var context = new ApplicationDbContext())
            {
                var query = context.Likes
                    .Where(x => x.Author == _userId && x.Liked == true)
                    .Select(x => new LikeListItem
                    {
                        Author = x.Author,
                        LikedPost = x.LikedPost
                    });

                return query.ToArray();
            }
        }
    }
}
