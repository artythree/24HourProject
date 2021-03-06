﻿using TwentyFourHourProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourProject.Data;

namespace TwentyFourHourProject.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }

        // CreatePost()
        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
            {
                Author = _userId,
                Title = model.Title,
                Content = model.Content
            };

            using (var context = new ApplicationDbContext())
            {
                context.Posts.Add(entity);
                return context.SaveChanges() == 1;
            }
        }

        // GetPosts()
        public IEnumerable<PostListItem> GetPosts()
        {
            using (var context = new ApplicationDbContext())
            {
                var query = context.Posts
                    .Where(x => x.Author == _userId)
                    .Select(x => new PostListItem
                    {
                        PostId = x.PostId,
                        Title = x.Title
                    });

                return query.ToArray();
            }
        }
    }
}
