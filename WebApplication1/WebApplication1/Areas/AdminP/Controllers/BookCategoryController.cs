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
    public class BookCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public BookCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.BookCategories);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            BookCategory bookcategory =await _db.BookCategories.FindAsync(id);
            if (bookcategory == null) return NotFound();

            return View(bookcategory);
        }

        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookCategory bookCategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isValid = _db.BookCategories.Any(c => c.CategoryName.ToLower() == bookCategory.CategoryName.ToLower());
            if (isValid)
            {
                ModelState.AddModelError("CategoryName", "Bu adda kateqoriya artıq mövcuddur");
                return View();
            }
           
            await _db.BookCategories.AddAsync(bookCategory);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            BookCategory bookCategory =await _db.BookCategories.FindAsync(id);
            if (bookCategory == null) return NotFound();

            return View(bookCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,BookCategory bookCategory)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            if (id == null) return NotFound();
            BookCategory dbcategory = _db.BookCategories.FirstOrDefault(c => c.Id == id);
            if (dbcategory == null) return NotFound();
            BookCategory checkcategory = _db.BookCategories.FirstOrDefault(c => c.CategoryName.ToLower() == bookCategory.CategoryName.ToLower());

            if (checkcategory!=null)
            {
                if (dbcategory.CategoryName != checkcategory.CategoryName) { 
                ModelState.AddModelError("CategoryName", "Bu adda kateqoriya artıq mövcuddur");
                return View();
                }
            }

           
            dbcategory.CategoryName = bookCategory.CategoryName;
            dbcategory.Description = bookCategory.Description;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            BookCategory bookCategory = await _db.BookCategories.FindAsync(id);
            if (bookCategory == null) return NotFound();

            return View(bookCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            BookCategory bookCategory = await _db.BookCategories.FindAsync(id);
            if (bookCategory == null) return NotFound();

            _db.BookCategories.Remove(bookCategory);
            await _db.SaveChangesAsync();
           return RedirectToAction("Index");
        }
    }


}