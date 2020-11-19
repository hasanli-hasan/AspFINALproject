using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _sigInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> sigInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _sigInManager = sigInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            if (!ModelState.IsValid) return View();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser loginUser =await _userManager.FindByEmailAsync(login.Email);
            

            if (loginUser == null)
            {
                ModelState.AddModelError("","Email və ya Password Səhvdir");
                return View(login);
            }

            if(!loginUser.IsActivated)
            {
                ModelState.AddModelError("", "Hesabınız  Bloklanıb");
                return View(login);
            }
            var signinResult =await _sigInManager.PasswordSignInAsync(loginUser, login.Password, true,true);

            if (signinResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Hesabınız Müvəqqəti Bloklanıb");
                return View(login);
            }

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Email və ya Password Səhvdir");
                return View(login);
            }

            string role = (await _userManager.GetRolesAsync(loginUser))[0];
            if (role == "Admin")
            {
                return RedirectToAction("Index", "Dashboard",new {area="AdminP"});
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();

            AppUser newUser = new AppUser
            {
                FullName=register.FullName,
                UserName=register.UserName,
                Email=register.Email,
            };

            IdentityResult identityResult =await _userManager.CreateAsync(newUser, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
                return View(register);
            }

           //await _userManager.AddToRoleAsync(newUser, "Admin");
            await _userManager.AddToRoleAsync(newUser, "User");

            await _sigInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
        
            await _sigInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        //public async Task CreateRole()
        //{
        //    if(!await _roleManager.RoleExistsAsync("Admin"))
        //        await _roleManager.CreateAsync(new IdentityRole { Name ="Admin" });


        //    if (!await _roleManager.RoleExistsAsync("User"))
        //        await _roleManager.CreateAsync(new IdentityRole { Name ="User" });

        //}
    }
}