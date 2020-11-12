using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _db;
        public AuthorController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Authors);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Author author = await _db.Authors.FindAsync(id);
            if (author == null) return NotFound();

            return View(author);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isValid = _db.Authors.Any(c => c.AuthorName.ToLower() == author.AuthorName.ToLower());
            if (isValid)
            {
                ModelState.AddModelError("AuthorName", "Bu adda Author artıq mövcuddur");
                return View();
            }

            await _db.Authors.AddAsync(author);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Author author = await _db.Authors.FindAsync(id);
            if (author == null) return NotFound();

            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Author author)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null) return NotFound();
            Author dbauthor = _db.Authors.FirstOrDefault(c => c.Id == id);
            if (dbauthor == null) return NotFound();
            Author checkauthor = _db.Authors.FirstOrDefault(c => c.AuthorName.ToLower() == author.AuthorName.ToLower());

            if (checkauthor != null)
            {
                if (dbauthor.AuthorName != checkauthor.AuthorName)
                {
                    ModelState.AddModelError("AuthorName", "Bu adda author artıq mövcuddur");
                    return View();
                }
            }


            dbauthor.AuthorName = author.AuthorName;
            dbauthor.Description = author.Description;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Author author = await _db.Authors.FindAsync(id);
            if (author == null) return NotFound();

            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            Author author = await _db.Authors.FindAsync(id);
            if (author == null) return NotFound();

            _db.Authors.Remove(author);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}