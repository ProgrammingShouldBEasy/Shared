using BlogPostWebsite.Models;
using BlogPostWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogPostWebsite.Data
{
    public class BlogRepositoryEF : IBlogRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BlogRepositoryEF()
        {
            dbContext = new ApplicationDbContext();
        }

        public void Add(Post post)
        {
            dbContext.Post.Add(post);
            dbContext.SaveChanges();
        }

        public List<Post> GetAllPosts()
        {
            return dbContext.Post.ToList();
        }
    }
}