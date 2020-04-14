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
            new Post{ PostId=1, Title="This is title 1", Description="This is description 1",AuthorId="6c1ef128-cf77-4816-8fcd-126384191d9a",CategoryId=1,DateModified=DateTime.Parse("2/2/2020"),DatePosted=DateTime.Parse("6/4/2020")},
            new Post{ PostId=2, Title="This is title 2", Description="This is description 2",AuthorId="6c1ef128-cf77-4816-8fcd-126384191d9a",CategoryId=2,DateModified=DateTime.Parse("3/4/2020"),DatePosted=DateTime.Parse("9/9/2020")},
            new Post{ PostId=3, Title="This is title 3", Description="This is description 3",AuthorId="6c1ef128-cf77-4816-8fcd-126384191d9a",CategoryId=2,DateModified=DateTime.Parse("3/4/2020"),DatePosted=DateTime.Parse("8/9/2020")},
            new Post{ PostId=4, Title="This is title 4", Description="This is description 4",AuthorId="73a7f92a-de5c-4614-8b27-2ef7327d5fe8",CategoryId=2,DateModified=DateTime.Parse("5/4/2020"),DatePosted=DateTime.Parse("3/9/2020")},
            new Post{ PostId=5, Title="This is title 5", Description="This is description 5",AuthorId="73a7f92a-de5c-4614-8b27-2ef7327d5fe8",CategoryId=2,DateModified=DateTime.Parse("8/4/2020"),DatePosted=DateTime.Parse("5/9/2020")},
            new Post{ PostId=6, Title="This is title 6", Description="This is description 6",AuthorId="73a7f92a-de5c-4614-8b27-2ef7327d5fe8",CategoryId=2,DateModified=DateTime.Parse("8/4/2020"),DatePosted=DateTime.Parse("5/9/2020")}
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