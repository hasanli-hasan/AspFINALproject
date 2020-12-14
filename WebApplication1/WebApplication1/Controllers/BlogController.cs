using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count()/6);
            ViewBag.Page = page;

            if (page==null)
            {
                HomeVM homeVM = new HomeVM
                {

                    BlogCategories = _db.BlogCategories.Include(c => c.Blogs).ToList(),
                    Blogs = _db.Blogs.Include(p => p.BlogCategory).OrderByDescending(b=>b.Id).Take(6),
                    OldBlogs=_db.Blogs.Take(7).ToList()

                };

                return View(homeVM);
            }
            else
            {
                HomeVM homeVM = new HomeVM
                {

                    BlogCategories = _db.BlogCategories.Include(c=>c.Blogs).ToList(),
                    Blogs = _db.Blogs.Include(p => p.BlogCategory).OrderByDescending(b=>b.Id).Skip(((int)page - 1)*6).Take(6),
                    OldBlogs = _db.Blogs.Take(7).ToList()

                };

                return View(homeVM);
            }
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Blog> blog = _db.Blogs.Where(b => b.Title.Contains(search)).OrderByDescending(x => x.Id).Take(14);

            return PartialView("_SearchBlogPartial",blog);
        }


        public async Task<IActionResult> BlogDetail(int? id)
        {
            AppUser actUser = await _userManager.FindByNameAsync(User.Identity.Name);
            Blog blog = _db.Blogs.Where(x => x.Id == id).FirstOrDefault();
            AppUser writerUser = _db.Users.FirstOrDefault(x => x.Id == blog.AppUserId);

            ViewBag.WriterImage = writerUser.Image;
            ViewBag.WriterName = writerUser.UserName;

            ViewBag.UserImage = actUser.Image;
            List<Commet> DbCommets = _db.Commets.Where(c => c.BlogId == blog.Id).Where(i=>i.isAppend==false).Include(x=>x.Blog).ToList();

            BlogVM blogVM = new BlogVM
            {
                Id=blog.Id,
                Image = blog.Image,
                Title = blog.Title,
                FrontText = blog.FrontText,
                BlogText = blog.BlogText,
                DateTime = blog.DateTime,
               Commets=DbCommets,
               
            };

            return View(blogVM);
        }

        [HttpPost]
        public async Task<IActionResult> BlogDetail([FromForm] BlogVM blog)
        {
            
            if (blog.Text == null) return RedirectToAction("BlogDetail");

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var commet = new Commet();
            commet.Text = blog.Text;
            commet.BlogId = blog.Id;
            commet.AppUserId = appUser.Id;
            commet.Date = DateTime.Now;
            commet.UserName = appUser.UserName;
            commet.CommentImage = appUser.Image;
            _db.Commets.Add(commet);
            _db.SaveChanges();

            return Ok(new {Text=commet.Text,Date=commet.Date.ToString("dd/MM/yyyy"), UserName=commet.UserName, CommentImage = commet.CommentImage,CommetId=commet.Id });
        }


        public IActionResult CategoryBlog(int? id,int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Where(x=>x.BlogCategoryId==id).Count()/6);
            ViewBag.Page = page;

            if (page==null)
            {
                HomeVM homeVM = new HomeVM
                {
                    Blogs = _db.Blogs.Include(x => x.BlogCategory).OrderByDescending(x=>x.Id).Where(b => b.BlogCategoryId == id).ToList(),
                    BlogCategories = _db.BlogCategories
                };

                return View(homeVM);
            }
            else
            {
                HomeVM homeVM = new HomeVM
                {
                    Blogs = _db.Blogs.Include(x => x.BlogCategory).Where(b => b.BlogCategoryId == id).OrderByDescending(x=>x.Id).Skip(((int)page - 1) * 6).Take(6),
                    BlogCategories = _db.BlogCategories
                };

                return View(homeVM);
            }
        }

   
     public async Task<IActionResult> DeleteCommet(int? id)
        {
            if (id == null) return NotFound();
            Commet dbcommet =await _db.Commets.FindAsync(id);

           
            dbcommet.isAppend =true;
            await _db.SaveChangesAsync();

            //return RedirectToAction("BlogDetail",new { Id=dbcommet.BlogId});
            return NoContent();
        }


    }
}