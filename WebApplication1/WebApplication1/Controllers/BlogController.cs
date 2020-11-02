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
    public class BlogController : Controller
    {
        AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
               
                BlogCategories=_db.BlogCategories.ToList(),
                Blogs=_db.Blogs.Include(p=>p.BlogCategory)
                
            };

            return View(homeVM);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Blog> blog = _db.Blogs.Where(b => b.Title.Contains(search)).OrderByDescending(x => x.Id).Take(4);

            return PartialView("_SearchBlogPartial",blog);
        }

        
    }
}