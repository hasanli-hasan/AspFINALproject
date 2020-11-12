using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Extentions;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public BlogController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Blogs.Include(c=>c.BlogCategory));
        }

        public IActionResult Create()
        {
            ViewBag.BlogCategory = new SelectList(_db.BlogCategories.ToList(), "Id", "Name");
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }


            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                return View();
            }

            if (blog.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                return View();
            }

            string fileName = await blog.Photo.SaveImg(_env.WebRootPath, "img");
            blog.Image = fileName;

            await _db.Blogs.AddAsync(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Include(c=>c.BlogCategory).Where(b => b.Id == id).FirstOrDefault();
            if (blog == null) return NotFound();

            return View(blog);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Include(c => c.BlogCategory).FirstOrDefault(b => b.Id == id);
            if (blog == null) return NotFound();

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", blog.Image);

            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Include(c => c.BlogCategory).FirstOrDefault(b => b.Id == id);
            if (blog == null) return NotFound();

            ViewBag.BlogCategory = new SelectList(_db.BlogCategories.ToList(), "Id", "Name");
            

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            if (id == null) return NotFound();

            if (blog.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                    return View();
                }

                if (blog.Photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                    return View();
                }

                Blog dbblog = await _db.Blogs.FindAsync(id);
                if (dbblog == null) return NotFound();
                Helper.DeleteImage(_env.WebRootPath, "img", dbblog.Image);

                string fileName = await blog.Photo.SaveImg(_env.WebRootPath, "img");
                dbblog.Image = fileName;
                dbblog.Title = blog.Title;
                dbblog.BlogText = blog.BlogText;
                dbblog.DateTime = blog.DateTime;
                dbblog.FrontText = blog.FrontText;
                dbblog.BlogCategoryId= blog.BlogCategoryId;
                await _db.SaveChangesAsync();
            }
            else
            {
                Blog dbblog = await _db.Blogs.FindAsync(id);
                if (dbblog == null) return NotFound();
                dbblog.Title = blog.Title;
                dbblog.BlogText = blog.BlogText;
                dbblog.DateTime = blog.DateTime;
                dbblog.FrontText = blog.FrontText;
                dbblog.BlogCategoryId = blog.BlogCategoryId;
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");

        }
    }
}