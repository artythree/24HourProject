using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHour.Data;

namespace _24Hour.Services
{
    public class CommentService
    {
        public IEnumerable<CommentListItem> GetComments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                         .Comment
                         .Where(e => e.Author == _userId)
                         .Select(
                            e =>
                                new CommentsListItem
                                {
                                    Author = e.Author,
                                    Text = e.Text,
                                    CommentPost = e.CommentPost,
                                }
                        );
                return query.ToArray();

            }
        }
        public CommentDetail GetCommentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comment
                        .Single(e => e.Author == id && e.Author == _userId);
                return
                    new CommentDetail
                    {
                        Author = entity.Author,
                        Text = entity.Text,
                        CommentPost = entity.CommentPost,

                    };

            }
        }
    }
}
