using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Extentions;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    public class SliderController : Controller
    {
       private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_db.BookSliders);
        }

        public IActionResult Create()
        {
            if (_db.BookSliders.Count() >= 5)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookSlider bookSlider)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if(!bookSlider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                return View();
            }

            if(bookSlider.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                return View();
            }

            if (_db.BookSliders.Count() >= 5)
            {
                return RedirectToAction("Index");
            }

            string fileName = await bookSlider.Photo.SaveImg(_env.WebRootPath, "img");
            bookSlider.Image = fileName;

            await _db.BookSliders.AddAsync(bookSlider);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            BookSlider bookSlider =await _db.BookSliders.FindAsync(id);
            if (bookSlider == null) return NotFound();

            return View(bookSlider);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            BookSlider bookSlider = await _db.BookSliders.FindAsync(id);
            if (bookSlider == null) return NotFound();

            return View(bookSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            BookSlider bookSlider = await _db.BookSliders.FindAsync(id);
            if (bookSlider == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", bookSlider.Image);

            _db.BookSliders.Remove(bookSlider);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            BookSlider bookSlider = await _db.BookSliders.FindAsync(id);
            if (bookSlider == null) return NotFound();

            return View(bookSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BookSlider bookSlider)
        {
            if (id == null) return NotFound();

           if(bookSlider.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!bookSlider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                    return View();
                }

                if (bookSlider.Photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                    return View();
                }

                BookSlider dbslider =await _db.BookSliders.FindAsync(id);
                if (dbslider == null) return NotFound();
                Helper.DeleteImage(_env.WebRootPath,"img", dbslider.Image);

                string fileName = await bookSlider.Photo.SaveImg(_env.WebRootPath, "img");
                dbslider.Image = fileName;
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
            
        }

    }

 
}