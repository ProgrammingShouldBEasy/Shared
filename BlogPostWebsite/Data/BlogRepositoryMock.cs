using BlogPostWebsite.Models;
using BlogPostWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPostWebsite.Data
{
    public class BlogRepositoryMock : IBlogRepository
    {
        private static readonly List<Post> _allPosts = new List<Post>()
        {
            new Post{ PostId=1, Title="This is title", Description="This is description 1",AuthorId=1,CategoryId=1,DateModified=DateTime.Parse("2/2/2020"),DatePosted=DateTime.Parse("6/4/2020")},
            new Post{ PostId=2, Title="This is title2", Description="This is description 2",AuthorId=1,CategoryId=2,DateModified=DateTime.Parse("3/4/2020"),DatePosted=DateTime.Parse("9/9/2020")}
        };

        public void Add(Post post)
        {
            post.PostId = _allPosts.Max(p => p.PostId) + 1;
            _allPosts.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return _allPosts;
        }
    }
}