using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
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
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Books = _db.Books.ToList(),
                Authors = _db.Authors.ToList(),
                BookCategories=_db.BookCategories.ToList(),
                BookSliders = _db.BookSliders.ToList(),
                MRClassics=_db.MRClassics.ToList(),
                SpecialBooks=_db.SpecialBooks.ToList()
            };
            return View(homeVM);
        }
    }
}