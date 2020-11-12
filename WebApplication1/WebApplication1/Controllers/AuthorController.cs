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
    public class AuthorController : Controller
    {
        AppDbContext _db;
        public AuthorController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                AuthorAbouts=_db.AuthorAbouts.Take(6)
            };
            ViewBag.AuthorCount = _db.AuthorAbouts.Count();
           
            return View(homeVM);
        }

        public IActionResult Load(int skip)
        {
            //if (skip>= _db.AuthorAbouts.Count())
            //{
            //    return Content("All Info You Show");
            //}

            IEnumerable<AuthorAbout> model = _db.AuthorAbouts.Skip(skip).Take(6);
            return PartialView("_AuthorPartial",model);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<AuthorAbout> author =
                _db.AuthorAbouts.Where(a => a.NameSurname.Contains(search)).OrderByDescending(x=>x.Id).Take(4);

            return PartialView("_SearchAuthorPartial",author);
        }

        public IActionResult AuthorDetail(int? id)
        {
            AuthorAbout author = _db.AuthorAbouts.Where(x => x.Id == id).FirstOrDefault();
            return View(author);
        }
    }
}