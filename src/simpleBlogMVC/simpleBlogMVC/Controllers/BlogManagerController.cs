using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nb.BlogLibrary1;

namespace simpleBlogMVC.Controllers
{
    [Authorize]
    public class BlogManagerController : Controller
    {
        private BlogRepository _blogRepo = new BlogRepository();

        // GET: BlogManager
        public IActionResult Index()
        {
            return View(_blogRepo.GetBlogList());
        }

        // GET: BlogManager/Details/5
        public IActionResult Details(int id)
        {
            return View(_blogRepo.GetBlogById(id));
        }

        // GET: BlogManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BlogManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog newBlog, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _blogRepo.Add(newBlog);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(newBlog);
            }
        }

        // GET: BlogManager/Edit/5
        public IActionResult Edit(int id)
        {
            return View(_blogRepo.GetBlogById(id));
        }

        // POST: BlogManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Blog updateBlog, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _blogRepo.Edit(updateBlog);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(updateBlog);
            }
        }

        // GET: BlogManager/Delete/5
        public IActionResult Delete(int id)
        {
            return View(_blogRepo.GetBlogById(id));
        }

        // POST: BlogManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _blogRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}