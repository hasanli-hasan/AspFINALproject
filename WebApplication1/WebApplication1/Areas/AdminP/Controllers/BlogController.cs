using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Extentions;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    [Authorize(Roles = "Admin,Writer")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public BlogController(AppDbContext db, IHostingEnvironment env, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 6);
            ViewBag.Page = page;

            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            var role = (await _userManager.GetRolesAsync(existUser))[0];
            if (role=="Writer")
            {
                ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Where(x=>x.AppUserId==existUser.Id).Count()/6);
                ViewBag.Page = page;

                if (page == null)
                {
                    return View(_db.Blogs.Include(c => c.BlogCategory).Where(x=>x.AppUserId==existUser.Id).OrderByDescending(b => b.Id).Take(6).ToList());
                }
                else
                {
                    return View(_db.Blogs.Include(c => c.BlogCategory).Where(x => x.AppUserId == existUser.Id).OrderByDescending(b => b.Id).Skip(((int)page - 1) * 6).Take(6).ToList());
                }
            }

            if (page == null)
            {
                return View(_db.Blogs.Include(c => c.BlogCategory).OrderByDescending(b => b.Id).Take(6).ToList());
            }
            else
            {
                return View(_db.Blogs.Include(c => c.BlogCategory).OrderByDescending(b => b.Id).Skip(((int)page - 1) * 6).Take(6).ToList());
            }
           
        }

        public IActionResult Create()
        {
            ViewBag.BlogCategory = new SelectList(_db.BlogCategories.ToList(), "Id", "Name");
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }


            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                return View();
            }

            if (blog.Photo.MaxLength(200))
            {
                ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                return View();
            }

            string fileName = await blog.Photo.SaveImg(_env.WebRootPath, "img");
            blog.Image = fileName;

            AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);
            blog.AppUserId=existUser.Id;

            await _db.Blogs.AddAsync(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Include(c=>c.BlogCategory).Where(b => b.Id == id).FirstOrDefault();
           
            if (blog == null) return NotFound();

            return View(blog);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Include(c => c.BlogCategory).FirstOrDefault(b => b.Id == id);
            if (blog == null) return NotFound();

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", blog.Image);

            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Include(c => c.BlogCategory).FirstOrDefault(b => b.Id == id);
            if (blog == null) return NotFound();

            ViewBag.BlogCategory = new SelectList(_db.BlogCategories.ToList(), "Id", "Name");
            

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            if (id == null) return NotFound();

            if (blog.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                    return View();
                }

                if (blog.Photo.MaxLength(800))
                {
                    ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                    return View();
                }

                Blog dbblog = await _db.Blogs.FindAsync(id);
                if (dbblog == null) return NotFound();
                Helper.DeleteImage(_env.WebRootPath, "img", dbblog.Image);

                string fileName = await blog.Photo.SaveImg(_env.WebRootPath, "img");
                dbblog.Image = fileName;
                dbblog.Title = blog.Title;
                dbblog.BlogText = blog.BlogText;
                dbblog.DateTime = blog.DateTime;
                dbblog.FrontText = blog.FrontText;
                dbblog.BlogCategoryId= blog.BlogCategoryId;
                await _db.SaveChangesAsync();
            }
            else
            {
                Blog dbblog = await _db.Blogs.FindAsync(id);
                if (dbblog == null) return NotFound();
                dbblog.Title = blog.Title;
                dbblog.BlogText = blog.BlogText;
                dbblog.DateTime = blog.DateTime;
                dbblog.FrontText = blog.FrontText;
                dbblog.BlogCategoryId = blog.BlogCategoryId;
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");

        }
    }
}