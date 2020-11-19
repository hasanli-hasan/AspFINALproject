﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.View_Models;

namespace WebApplication1.View_Components
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.BasketCount = 0;
            if (Request.Cookies["basket"] !=null)
            {
                List<BasketBookVM> books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);
                ViewBag.BasketCount = books.Count;

            }
            Bio model = _db.Bios.FirstOrDefault();

            ViewBag.UserName = "";
            if(User.Identity.IsAuthenticated)
              {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserName = user.UserName;
              }

            return View(await Task.FromResult(model));
        }
    }
}
