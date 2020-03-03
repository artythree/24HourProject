using _24Hours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHour.Data;

namespace _24Hour.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        //CreateReply()
        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    OwnerId = _userId,
                    Content = model.Content,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //GetReplies()
        public IEnumerable<ReplyListItem> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Replies
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new ReplyListItem
                                {
                                    ReplyId = e.ReplyId, //EAC did not include Title = e.Title because replies don't have titles
                                    CreatedUtc = e.CreatedUtc
                                }
                        );

                return query.ToArray();
            }
        }
    }
}
