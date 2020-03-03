using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Models;
using TwentyFourHourProject.Data;


namespace TwentyFourHourProject.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        public CommentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity = new Comment()
            {
                Author = _userId,
                CommentPost = model.CommentPost,
                Text = model.Content
            };

            using (var context = new ApplicationDbContext())
            {
                context.Comments.Add(entity);
                return context.SaveChanges() == 1;
            }
        }

        public IEnumerable<CommentListItem> GetComments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                         .Comments
                         .Where(e => e.Author == _userId)
                         .Select(
                            e =>
                                new CommentListItem
                                {
                                    Author = e.Author,
                                    Text = e.Text,
                                    CommentPost = e.CommentPost,
                                }
                        );
                return query.ToArray();

            }
        }
        public CommentListItem GetCommentById(Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.Author == id && e.Author == _userId);
                return
                    new CommentListItem
                    {
                        Author = entity.Author,
                        Text = entity.Text,
                        CommentPost = entity.CommentPost,
                    };

            }
        }
    }
}
