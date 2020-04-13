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
        public string DatePosted { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}