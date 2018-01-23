using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using nb.BlogLibrary1;
using simpleBlogMVC.Models;

namespace simpleBlogMVC.Controllers
{
   
    public class HomeController : Controller
    {
        private BlogRepository _blogRepo = new BlogRepository();
        public IActionResult Index()
        {
            return View(_blogRepo.GetBlogList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult BlogPost(int id)
        {
            return View(_blogRepo.GetBlogById(id));
        }
    }
}
