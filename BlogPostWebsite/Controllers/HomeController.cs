<<<<<<< Updated upstream
﻿using System;
=======
﻿using BlogPostWebsite.Data;
using BlogPostWebsite.Models;
using BlogPostWebsite.Models.Interfaces;
using System;
>>>>>>> Stashed changes
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

        public ActionResult IndexUpdated(PostViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult IndexAddPost(Post post)
        {
            PostViewModel model = new PostViewModel();
            return View("IndexUpdated", model);
        }

        [HttpPost]
        public ActionResult IndexAddComment(Comment comment)
        {
            PostViewModel model = new PostViewModel();
            return View("IndexUpdated", model);
        }
    }
}