using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        AppDbContext _db;
        public BookController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Books.Count() / 16);
            ViewBag.Page = page;

            if (page == null)
            {
                List<Book> Books = _db.Books.Include(x => x.BookCategory).OrderByDescending(x=>x.Id).Take(16).ToList();

                HomeVM homeVM = new HomeVM
                {
                    Books = Books,
                    Authors = _db.Authors.ToList(),
                    BookCategories = _db.BookCategories.Include(x=>x.Books).ToList(),
                    BookSliders = _db.BookSliders.ToList()
                };
                return View(homeVM);
            }
            else
            {
                List<Book> Books = _db.Books.Include(x => x.BookCategory).OrderByDescending(b => b.Id).Skip(((int)page - 1) * 16).Take(16).ToList();

                HomeVM homeVM = new HomeVM
                {
                    Books = Books,
                    Authors = _db.Authors.ToList(),
                    BookCategories = _db.BookCategories.Include(x => x.Books).ToList(),
                    BookSliders = _db.BookSliders.ToList()
                };
                return View(homeVM);
            }

        }

        public IActionResult Search(string search)
        {
            IEnumerable<Book> book = _db.Books.Where(b => b.BookName.Contains(search)).OrderByDescending(x => x.Id).Take(10);
            return PartialView("_SearchBookPartial",book);
        }

        public IActionResult BookDetail(int? id)
        {
            Book book = _db.Books.Include(x => x.Author).Where(x => x.Id == id).FirstOrDefault();
            return View(book);
        }

        public IActionResult CategoryBook(int? id)
        {
            HomeVM homeVM = new HomeVM
            {
                Books = _db.Books.Include(x => x.BookCategory).Where(c => c.BookCategoryId == id).ToList(),
                Authors = _db.Authors.ToList(),
                BookCategories =_db.BookCategories.Where(x=>x.Id==id)
               
            };

          
            return View(homeVM);
        }
    }
}