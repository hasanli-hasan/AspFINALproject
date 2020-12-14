using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    [Authorize(Roles = "Admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public BlogCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.BlogCategories);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCategory blogCategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isValid = _db.BlogCategories.Any(c => c.Name.ToLower() == blogCategory.Name.ToLower());
            if (isValid)
            {
                ModelState.AddModelError("CategoryName", "Bu adda kateqoriya artıq mövcuddur");
                return View();
            }

            await _db.BlogCategories.AddAsync(blogCategory);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory blogCategory = await _db.BlogCategories.FindAsync(id);
            if (blogCategory == null) return NotFound();

            return View(blogCategory);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory blogCategory = await _db.BlogCategories.FindAsync(id);
            if (blogCategory == null) return NotFound();

            return View(blogCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BlogCategory blogCategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null) return NotFound();
            BlogCategory dbcategory = _db.BlogCategories.FirstOrDefault(c => c.Id == id);
            if (dbcategory == null) return NotFound();
            BlogCategory checkcategory = _db.BlogCategories.FirstOrDefault(c => c.Name.ToLower() == blogCategory.Name.ToLower());

            if (checkcategory != null)
            {
                if (dbcategory.Name != checkcategory.Name)
                {
                    ModelState.AddModelError("CategoryName", "Bu adda kateqoriya artıq mövcuddur");
                    return View();
                }
            }


            dbcategory.Name = blogCategory.Name;
            dbcategory.Description = blogCategory.Description;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory blogCategory = await _db.BlogCategories.FindAsync(id);
            if (blogCategory == null) return NotFound();

            return View(blogCategory);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory blogCategory = await _db.BlogCategories.FindAsync(id);
            if (blogCategory == null) return NotFound();

            _db.BlogCategories.Remove(blogCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}