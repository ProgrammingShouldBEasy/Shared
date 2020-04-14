using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogPostWebsite.Models;

namespace BlogPostWebsite.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateModified { get; set; }
        public string AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}