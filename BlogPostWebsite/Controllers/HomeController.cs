using BlogPostWebsite.Data;
using BlogPostWebsite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPostWebsite.Controllers
{
    public class HomeController : Controller
    {
        readonly IBlogRepository _blogRepository;
        public HomeController()
        {
            _blogRepository = BlogManager.Create();
        }
        public ActionResult Index()
        {
            return View("Index", _blogRepository.GetAllPosts());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}