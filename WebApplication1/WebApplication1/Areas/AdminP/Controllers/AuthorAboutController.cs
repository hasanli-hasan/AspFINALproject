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
    public class AuthorAboutController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public AuthorAboutController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.AuthorAbouts);
        }

        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AuthorAbout authorAbout)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }


            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!authorAbout.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                return View();
            }

            if (authorAbout.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                return View();
            }

            string fileName = await authorAbout.Photo.SaveImg(_env.WebRootPath, "img");
            authorAbout.Image = fileName;

            await _db.AuthorAbouts.AddAsync(authorAbout);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AuthorAbout authorAbout =await _db.AuthorAbouts.FindAsync(id);
            if (authorAbout == null) return NotFound();

            return View(authorAbout);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            AuthorAbout authorAbout = await _db.AuthorAbouts.FindAsync(id);
            if (authorAbout == null) return NotFound();

            return View(authorAbout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            AuthorAbout authorAbout = await _db.AuthorAbouts.FindAsync(id);
            if (authorAbout == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", authorAbout.Image);

            _db.AuthorAbouts.Remove(authorAbout);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            AuthorAbout authorAbout =await _db.AuthorAbouts.FindAsync(id);
            if (authorAbout == null) return NotFound();

            return View(authorAbout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, AuthorAbout authorAbout)
        {
            if (id == null) return NotFound();

            if (authorAbout.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!authorAbout.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                    return View();
                }

                if (authorAbout.Photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                    return View();
                }

                AuthorAbout dbAbout = await _db.AuthorAbouts.FindAsync(id);
                if (dbAbout == null) return NotFound();
                Helper.DeleteImage(_env.WebRootPath, "img", dbAbout.Image);

                string fileName = await authorAbout.Photo.SaveImg(_env.WebRootPath, "img");
                dbAbout.Image = fileName;
                dbAbout.NameSurname = authorAbout.NameSurname;
                dbAbout.FrontTitle = authorAbout.FrontTitle;
                dbAbout.About = authorAbout.About;
                dbAbout.BookInfo = authorAbout.BookInfo;
                await _db.SaveChangesAsync();
            }
            else
            {
                AuthorAbout dbAbout = await _db.AuthorAbouts.FindAsync(id);
                if (dbAbout == null) return NotFound();
                dbAbout.NameSurname = authorAbout.NameSurname;
                dbAbout.FrontTitle = authorAbout.FrontTitle;
                dbAbout.About = authorAbout.About;
                dbAbout.BookInfo = authorAbout.BookInfo;
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");

        }

    }
}