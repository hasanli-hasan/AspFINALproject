using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Extentions;
using WebApplication1.Helpers;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    //[Authorize(Roles ="Admin")]
    public class BookController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public BookController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
       /* [AllowAnonymous]*/ //controllera qadaga olsa da bu action-a icaze verilir
        public IActionResult Index()
        {
            _db.Books.Include(b => b.Author).ToList();
            return View(_db.Books.Include(b => b.Author).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Authors = new SelectList(_db.Authors.ToList(), "Id", "AuthorName");
            ViewBag.Categories = new SelectList(_db.BookCategories.ToList(), "Id", "CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookCreateVM bookCreateVM)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }

            Book book = new Book
            {
                BookName= bookCreateVM.BookName,
                BookPrice=bookCreateVM.BookPrice,
                BookCount=bookCreateVM.BookCount,
                AboutBook=bookCreateVM.AboutBook,
                AuthorId=bookCreateVM.AuthorId,
                BookCategoryId=bookCreateVM.BookCategoryId,
                BookImage=bookCreateVM.BookImage,
                Photo=bookCreateVM.Photo

            };

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!bookCreateVM.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                return View();
            }

            if (bookCreateVM.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                return View();
            }

            string fileName = await bookCreateVM.Photo.SaveImg(_env.WebRootPath, "img");
            bookCreateVM.BookImage = fileName;
            Book newBook = new Book
            {
                BookName = bookCreateVM.BookName,
                BookPrice = bookCreateVM.BookPrice,
                BookCount = bookCreateVM.BookCount,
                AboutBook = bookCreateVM.AboutBook,
                AuthorId = bookCreateVM.AuthorId,
                BookCategoryId = bookCreateVM.BookCategoryId,
                BookImage = bookCreateVM.BookImage,
                Photo = bookCreateVM.Photo
            };


            await _db.Books.AddAsync(newBook);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Book book = _db.Books.Include(a => a.Author).Include(c=>c.BookCategory).Where(b => b.Id == id).FirstOrDefault();
            if (book == null) return NotFound();

            return View(book);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Book book =  _db.Books.Include(c=>c.BookCategory).Include(a=>a.Author).FirstOrDefault(b=>b.Id==id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Book book = await _db.Books.FindAsync(id);
            if (book == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", book.BookImage);

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public  IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Book book =  _db.Books.Include(c=>c.BookCategory).Include(a=>a.Author).FirstOrDefault(b=>b.Id==id);
            if (book == null) return NotFound();

            ViewBag.Authors = new SelectList(_db.Authors.ToList(), "Id", "AuthorName");
            ViewBag.Categories = new SelectList(_db.BookCategories.ToList(), "Id", "CategoryName");

            return View(book);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Book book)
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

                    if (book.Photo.MaxLength(200))
                    {
                        ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                        return View();
                    }

                    Book dbbook = await _db.Books.FindAsync(id);
                    if (dbbook == null) return NotFound();
                    Helper.DeleteImage(_env.WebRootPath, "img", dbbook.BookImage);

                    string fileName = await book.Photo.SaveImg(_env.WebRootPath, "img");
                    dbbook.BookImage = fileName;
                    dbbook.AboutBook = book.AboutBook;
                    dbbook.BookName = book.BookName;
                    dbbook.BookPrice = book.BookPrice;
                    dbbook.AuthorId = book.AuthorId;
                    dbbook.BookCategoryId = book.BookCategoryId;
                    await _db.SaveChangesAsync();
            }
            else
            {
                Book dbbook = await _db.Books.FindAsync(id);
                if (dbbook == null) return NotFound();
                dbbook.AboutBook = book.AboutBook;
                dbbook.BookName = book.BookName;
                dbbook.BookPrice = book.BookPrice;
                dbbook.AuthorId = book.AuthorId;
                dbbook.BookCategoryId = book.BookCategoryId;
                await _db.SaveChangesAsync();
            }
         
            return RedirectToAction("Index");

        }
    }
}