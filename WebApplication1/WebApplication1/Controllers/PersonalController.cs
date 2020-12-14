using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Extentions;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonalController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public PersonalController(UserManager<AppUser> userManager, AppDbContext db, IHostingEnvironment env)
        {
            _userManager = userManager;
            _db = db;
            _env = env;
        }
        public IActionResult Index(string name)
        {
            AppUser user = _db.Users.Where(x => x.UserName == name).Include(x=>x.Sales).FirstOrDefault();
           
            return View(user);
        }

         [HttpPost]
        public async Task<IActionResult> UserImage(AppUser user)
        {
            AppUser actUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!user.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil formatı seçin!");
                    return View();
                }

                if (user.Photo.MaxLength(2000))
                {
                    ModelState.AddModelError("Photo", "Sekil 200kb-dan artiq olmamalidir.");
                    return View();
                }

                if(actUser.Image != null)
                {
                    Helper.DeleteImage(_env.WebRootPath, "img", actUser.Image);
                }

                string fileName = await user.Photo.SaveImg(_env.WebRootPath, "img");
                actUser.Image = fileName;
                await _db.SaveChangesAsync();
            }
           
            return RedirectToAction("Index",new { name =actUser.UserName });
        }

        [HttpPost]
        public async Task<IActionResult> BirthDay(AppUser user)
        {
            AppUser actUser = await _userManager.FindByNameAsync(User.Identity.Name);
             actUser.BirthDate= user.BirthDate;
             await _db.SaveChangesAsync();
            return RedirectToAction("Index", new { name = actUser.UserName });
        }

        [HttpPost]
        public async Task<IActionResult> UserGender(AppUser user)
        {
            AppUser actUser = await _userManager.FindByNameAsync(User.Identity.Name);

            actUser.Gender = user.Gender;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", new { name = actUser.UserName });
        }


        [HttpPost]
        public async Task<IActionResult> UserReligion(AppUser user)
        {
            AppUser actUser = await _userManager.FindByNameAsync(User.Identity.Name);

            actUser.Religion = user.Religion;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", new { name = actUser.UserName });
        }

        [HttpPost]
        public async Task<IActionResult> UserBio(AppUser user)
        {
            AppUser actUser = await _userManager.FindByNameAsync(User.Identity.Name);

            actUser.Bio = user.Bio;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", new { name = actUser.UserName });
        }
    }
}