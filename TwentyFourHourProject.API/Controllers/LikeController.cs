﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwentyFourHourProject.Models;
using TwentyFourHourProject.Services;

namespace TwentyFourHourProject.API.Controllers
{
    public class LikeController : ApiController
    {
        public IHttpActionResult Get()
        {
            LikeService likeService = CreateLikeService();
            var likes = likeService.GetLikes();
            return Ok(likes);
        }

        public IHttpActionResult Like(LikeCreate like)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var likeService = CreateLikeService();

            if (!likeService.CreateLike(like))
                return InternalServerError();

            return Ok();

        }

        private LikeService CreateLikeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var likeService = new LikeService(userId);
            return likeService;
        }
    }
}
