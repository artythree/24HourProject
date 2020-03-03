using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                    Arthor = e.Arthor,
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
                        .Single(e => e.Arthor == id && e.Authur == _userId);
                return
                    new CommentDetail
                    {
                        Arthor = entity.Arthor,
                        Text = entity.Text,
                        CommentPost = entity.CommentPost,

                    };

            }
        }
    }
}
