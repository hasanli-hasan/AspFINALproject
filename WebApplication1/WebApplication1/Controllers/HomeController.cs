using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApplication1.DAL;
using WebApplication1.Models;
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
                Books=_db.Books.Include(x=>x.BookCategory).ToList(),
                Authors=_db.Authors.ToList(),
                RecommendationBook=_db.RecommendationBooks.FirstOrDefault(),
                DiscountBooks=_db.DiscountBooks.ToList(),
                DiscountText=_db.DiscountTexts.FirstOrDefault(),
                Blogs=_db.Blogs.ToList(),
                AuthorAbouts=_db.AuthorAbouts.ToList()
            };
            return View(homeVM);
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Book book = await _db.Books.FindAsync(id);
            
            if (book == null) return NotFound();

            List<BasketBookVM> books;
            if (Request.Cookies["basket"] == null)
            {
                books = new List<BasketBookVM>();
            }
            else
            {
                books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);
            }

            BasketBookVM existBook = books.FirstOrDefault(x => x.Id == id);

            if (existBook == null){
                BasketBookVM newProduct = new BasketBookVM
                {
                    Id = book.Id,
                    Count = 1
                };

                books.Add(newProduct);
              
            }
            else
            {
                existBook.Count++;
            }

            string basket = JsonConvert.SerializeObject(books);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });

            if(Request.Headers["X-Request-With"] == "XMLHttpRequest"){
                return RedirectToAction("Basket");
            }
           
            return Json(books.Count);
          
        }


        public async Task<IActionResult> Basket()
        {
            string basket = Request.Cookies["basket"];

            List<BasketBookVM> books =new List<BasketBookVM>();
            if (basket != null)
            {
               books = JsonConvert.DeserializeObject<List<BasketBookVM>>(basket);
                foreach (var item in books)
                {

                    Book dbBooks = await _db.Books.FindAsync(item.Id);
                    item.BookPrice = dbBooks.BookPrice;
                    item.BookName = dbBooks.BookName;
                    item.BookImage = dbBooks.BookImage;
                }
            }

          
            return View(books);
        }

        public async Task<IActionResult> DeleteBasket(int? id)
        {
            List<BasketBookVM> books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);
            books.Remove(books.Find(b => b.Id == id));
            string basket = JsonConvert.SerializeObject(books);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });
            return RedirectToAction("Basket");
        }

        public IActionResult Decrease(int? id)
        {
            List<BasketBookVM> books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);
            BasketBookVM book = books.Where(p => p.Id == id).FirstOrDefault();

            if(book.Count>1)
            {
                --book.Count;
            }
            else
            {
                books.Remove(book);
            }
            string basket = JsonConvert.SerializeObject(books);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });

            return RedirectToAction("Basket");
        }

        public IActionResult Upcrease(int? id)
        {
            List<BasketBookVM> books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);
            BasketBookVM book = books.Where(p => p.Id == id).FirstOrDefault();

                ++book.Count;
            string basket = JsonConvert.SerializeObject(books);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });

            return RedirectToAction("Basket");
        }
    }

    
}