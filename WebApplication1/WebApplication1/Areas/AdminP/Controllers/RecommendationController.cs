using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Extentions;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    [Authorize(Roles = "Admin")]
    public class RecommendationController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public RecommendationController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.RecommendationBooks.FirstOrDefault());
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            RecommendationBook book = _db.RecommendationBooks.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, RecommendationBook book)
        {
            if (id == null) return NotFound();

            if (book.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!book.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                    return View();
                }

                if (book.Photo.MaxLength(1000))
                {
                    ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                    return View();
                }

                RecommendationBook dbbook = await _db.RecommendationBooks.FindAsync(id);
                if (dbbook == null) return NotFound();
                Helper.DeleteImage(_env.WebRootPath, "img", dbbook.Image);

                string fileName = await book.Photo.SaveImg(_env.WebRootPath, "img");
                dbbook.Image = fileName;
                dbbook.Name = book.Name;
                dbbook.Author = book.Author;
                dbbook.Price = book.Price;

                await _db.SaveChangesAsync();
            }
            else
            {
                RecommendationBook dbbook = await _db.RecommendationBooks.FindAsync(id);
                if (dbbook == null) return NotFound();
                dbbook.Name = book.Name;
                dbbook.Author = book.Author;
                dbbook.Price = book.Price;
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");

        }
    }
}