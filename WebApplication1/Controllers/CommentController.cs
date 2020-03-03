using _24Hour.Services;
using _24Hours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwentyFourHour.Data;

namespace WebApplication1.Controllers
{
    public class CommentController : ApiController
    {
        public IHttpActionResult Get()
        {
            CommentService commentService = CreateCommentService();
            var comment = CommentService.GetComments();
            return Ok(comment);
        }

        public IHttpActionResult Post(CommentCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CommentCreate(Comment))
                return InternalServerError();

            return Ok();
        }
        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var commentService = new CommentService(userId);
            return commentService;
        }
    }
}
