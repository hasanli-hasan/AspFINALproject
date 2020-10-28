using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.View_Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Books=_db.Books.ToList(),
                Authors=_db.Authors.ToList(),
                RecommendationBook=_db.RecommendationBooks.FirstOrDefault(),
                DiscountBooks=_db.DiscountBooks.ToList(),
                DiscountText=_db.DiscountTexts.FirstOrDefault(),
                Blogs=_db.Blogs.ToList(),
                AuthorAbouts=_db.AuthorAbouts.ToList()
            };
            return View(homeVM);
        }
    }
}