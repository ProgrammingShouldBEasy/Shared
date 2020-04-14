using BlogPostWebsite.Data;
using BlogPostWebsite.Models;
using BlogPostWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPostWebsite.Controllers
{
    public class BlogController : Controller
    {
        readonly IBlogRepository _blogRepository;
        readonly ICommentRepository _commentRepository;
        public BlogController()
        {
            _blogRepository = BlogManager.Create();
            _commentRepository = CommentManager.Create();
        }
        // GET: Blog
        public ActionResult Index()
        {
            List<PostViewModel> postVM = new List<PostViewModel>();
            var allPosts = _blogRepository.GetAllPosts();

            var context = new ApplicationDbContext();

            if (allPosts != null && allPosts.Count > 0)
            {
                foreach (var post in allPosts)
                {
                    postVM.Add(new PostViewModel { Post = post, Comments = _commentRepository.GetCommentByPostId(post.PostId),AuthorName = context.Users.FirstOrDefault(u => u.Id == post.AuthorId).UserName });
                }
                return View("Index", postVM);
            }
            return View("Index");
        }
    }
}