using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
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


        public IActionResult BlogDetail(int? id)
        {
           
            Blog blog = _db.Blogs.Where(x => x.Id == id).FirstOrDefault();
            
            List<Commet> DbCommets = _db.Commets.Where(c => c.BlogId == blog.Id).Where(i=>i.isAppend==false).Include(x=>x.Blog).ToList();

            BlogVM blogVM = new BlogVM
            {
                Id=blog.Id,
                Image = blog.Image,
                Title = blog.Title,
                FrontText = blog.FrontText,
                BlogText = blog.BlogText,
                DateTime = blog.DateTime,
               Commets=DbCommets

            };

            return View(blogVM);
        }

        [HttpPost]
        public async Task<IActionResult> BlogDetail(/*[FromForm]*/ BlogVM blog)
        {
            if (blog.Text == null) return RedirectToAction("BlogDetail");

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var commet = new Commet();
            commet.Text = blog.Text;
            commet.BlogId = blog.Id;
            commet.AppUserId = appUser.Id;
            commet.Date = DateTime.Now;
            commet.UserName = appUser.UserName;
            _db.Commets.Add(commet);
            _db.SaveChanges();

            return NoContent();
        }

        public IActionResult CategoryBlog(int? id)
        {
            HomeVM homeVM = new HomeVM
            {
                Blogs = _db.Blogs.Include(x => x.BlogCategory).Where(b => b.BlogCategoryId == id).ToList(),
                BlogCategories=_db.BlogCategories
            };
            
            return View(homeVM);
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