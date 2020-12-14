using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;
        public HomeController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
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
                AuthorAbouts=_db.AuthorAbouts.ToList(),
                BlogCategories=_db.BlogCategories.ToList(),
                BookCategories=_db.BookCategories.ToList()
               
            };
            return View(homeVM);
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();

            if (!User.Identity.IsAuthenticated)
            {
                return NotFound();
                
            }

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

 
            BasketBookVM existBook = books.FirstOrDefault(x => x.Id == id && x.UserName== User.Identity.Name);

            if (existBook == null){

                BasketBookVM newProduct = new BasketBookVM
                {
                    Id = book.Id,
                    Count = 1,
                    UserName= User.Identity.Name
                };

                    books.Add(newProduct);
               
            }
            else
            {
                if (existBook.Count<book.BookCount)
                {
                    existBook.Count++;
                }
 
            }

                string basket = JsonConvert.SerializeObject(books);

                Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });

                if (Request.Headers["X-Request-With"] == "XMLHttpRequest")
                {
                    return RedirectToAction("Basket");
                }

                return Json(books.Where(x=>x.UserName==User.Identity.Name).Count());

        }


        public async Task<IActionResult> Basket()
        {
            AppUser currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
            string basket = Request.Cookies["basket"];
            List<BasketBookVM> userBooks = new List<BasketBookVM>();
            List<BasketBookVM> books =new List<BasketBookVM>();
            if (User.Identity.IsAuthenticated)
            {

                if (basket != null)
                {
                    books = JsonConvert.DeserializeObject<List<BasketBookVM>>(basket);
                    foreach (var item in books)
                    {
                        
                            Book dbBooks = await _db.Books.FindAsync(item.Id);
                            item.BookPrice = dbBooks.BookPrice;
                            item.BookName = dbBooks.BookName;
                            item.BookImage = dbBooks.BookImage;
                            item.BookCount = dbBooks.BookCount;

                        userBooks.Add(item);
                    }

                }
            }

          
            return View(userBooks);
        }

        public IActionResult DeleteBasket(int? id)
        {
           
            List<BasketBookVM> books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);
            books.Remove(books.Find(b => b.Id == id));

            //userin cookie-deki kitablarin toplam qiymetini tapmaq
            decimal total = 0;
            int basketCount = 0;
            foreach (var item in books)
            {
               
                if (item.UserName==User.Identity.Name)
                {
                    Book book = _db.Books.FirstOrDefault(x => x.Id == item.Id);
                    total += book.BookPrice;
                    basketCount++;
                }
            }
            decimal Total = total;
            int Count = basketCount;
            string basket = JsonConvert.SerializeObject(books);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(30) });

            return Ok(new {Total=Total, basketCount= basketCount});
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

        [HttpPost]
        [ActionName("Basket")]
        public async Task<IActionResult> BasketSale(string Number,string Message,string Address)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                Sale sale = new Sale
                {
                    Date=DateTime.Now,
                    AppUserId=appUser.Id
                };

                string basket = Request.Cookies["basket"];

                List<BasketBookVM> basketBooks = JsonConvert.DeserializeObject<List<BasketBookVM>>(basket);
                foreach (BasketBookVM item in basketBooks)
                {
                    Book dbBook = await _db.Books.FindAsync(item.Id);
                    if (dbBook.BookCount<item.Count)
                    {
                        TempData["error"] =$"{dbBook.BookName} kitabindan {dbBook.BookCount} -eded qalib" ;
                        return RedirectToAction("Basket");
                    }
                }

                List<SaleBook> saleBooks = new List<SaleBook>();
                decimal total = 0;

                foreach (BasketBookVM book in basketBooks.Where(x=>x.UserName==User.Identity.Name))
                {
                    Book dbBook = await _db.Books.FindAsync(book.Id);
                   
                    await DecreaseSalesCount(dbBook, book);

                    SaleBook saleBook = new SaleBook
                    {
                        BookPrice = dbBook.BookPrice,
                        Count=book.Count,
                        BookId=book.Id,
                        SaleId=sale.Id
                    };

                    total += book.Count * dbBook.BookPrice;
                    saleBooks.Add(saleBook);
                }
                sale.Number = Number;
                sale.Message = Message;
                sale.Address = Address;
                sale.Total = total;
                sale.SaleBooks = saleBooks;

               await _db.Sales.AddAsync(sale);
               await _db.SaveChangesAsync();

                TempData["success"] = "Satish Ugurla Yerine Yetirilib!";
                return RedirectToAction("Basket");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
           
        }

        private async Task DecreaseSalesCount(Book dbBook,BasketBookVM basketBook)
        {
             dbBook = await _db.Books.FindAsync(basketBook.Id);
            dbBook.BookCount = dbBook.BookCount - basketBook.Count;
        }
   
    } 
}