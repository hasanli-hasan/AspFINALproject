using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    public class AllUsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;
        public AllUsersController(UserManager<AppUser> userManager, AppDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<IActionResult> Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_userManager.Users.Count() / 3);
            ViewBag.Page = page;

            if (page==null)
            {
                List<AppUser> users = _userManager.Users.Take(3).ToList();
                List<UserVM> usersVM = new List<UserVM>();

                foreach (AppUser user in users)
                {
                    UserVM userVm = new UserVM
                    {
                        Id = user.Id,
                        FullName = user.FullName,
                        Email = user.Email,
                        UserName = user.UserName,
                        IsActivated = user.IsActivated,
                        Role = (await _userManager.GetRolesAsync(user))[0]
                    };

                    usersVM.Add(userVm);

                }

                return View(usersVM);
            }
            else
            {
                List<AppUser> users = _userManager.Users.Skip(((int)page - 1) * 3).Take(3).ToList();

                List<UserVM> usersVM = new List<UserVM>();

                foreach (AppUser user in users)
                {
                    UserVM userVm = new UserVM
                    {
                        Id = user.Id,
                        FullName = user.FullName,
                        Email = user.Email,
                        UserName = user.UserName,
                        IsActivated = user.IsActivated,
                        Role = (await _userManager.GetRolesAsync(user))[0]
                    };

                    usersVM.Add(userVm);

                }

                return View(usersVM);
            }

        }

        public async Task<IActionResult> IsActivate(string id)
        {
            if (id == null) return NotFound();
            AppUser user =await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IsActivate(string id,bool IsActivated)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            user.IsActivated = IsActivated;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            UserVM userVM = new UserVM
            {
                Id = user.Id,
                Email=user.Email,
                UserName=user.UserName,
                Role=(await _userManager.GetRolesAsync(user))[0],
                Roles=new List<string> { "User","Admin"}
            };

            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id,string Role)
        {
            if (Role == null) return NotFound();
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            string oldRole = (await _userManager.GetRolesAsync(user))[0];
            await _userManager.RemoveFromRoleAsync(user,oldRole);
            await _userManager.AddToRoleAsync(user, Role);
          
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id,string NewPassword)
        {
            if (NewPassword == null) return NotFound();
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
           IdentityResult identityResult= await _userManager.ResetPasswordAsync(user, token, NewPassword);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View();
                }
            }

            return RedirectToAction("Index");
        }
    }
}