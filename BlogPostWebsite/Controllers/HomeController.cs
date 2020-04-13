using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogPostWebsite.Models;

namespace BlogPostWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PostViewModel model = new PostViewModel();
            return View("Index", model);
        }

        public ActionResult Index(PostViewModel model)
        {
            return View(model);
        }

        public ActionResult Index(Post post)
        {
            PostViewModel model = new PostViewModel();
            return View("Index", model);
        }

        public ActionResult Index(Comment comment)
        {
            PostViewModel model = new PostViewModel();
            return View("Index", model);
        }
    }
}