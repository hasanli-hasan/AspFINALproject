using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            ViewBag.UserName = "";
            ViewBag.BasketCount = 0;
           
            if (User.Identity.IsAuthenticated)
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserName = user.UserName;
                ViewBag.UserImage = user.Image;

                if (Request.Cookies["basket"] != null)
                {
                    List<BasketBookVM> books = JsonConvert.DeserializeObject<List<BasketBookVM>>(Request.Cookies["basket"]);

                    //List<BasketBookVM> userProducts = new List<BasketBookVM>();
                    //foreach (BasketBookVM item in books.Where(x=>x.UserName==User.Identity.Name))
                    //{
                    //    userProducts.Add(item);
                        
                    //}
                    
                    ViewBag.BasketCount = books.Where(x => x.UserName == User.Identity.Name).Count();
                }
                
            }
            Bio model = _db.Bios.FirstOrDefault();

            //usere gelen mesajlarin countunu tapmaq ucun
            //count da eger user mesaj yazarsa gosterilir. hemin mesaj oxunsa count -1 azalacaq
            if (User.Identity.IsAuthenticated)
            {
                AppUser existUser = await _userManager.FindByNameAsync(User.Identity.Name);

                List<AppUser> users = _userManager.Users.Include(x => x.Messages).ToList();
                List<Conversation> conversations = _db.Conversations.ToList();
                List<Message> messages = _db.Messages.ToList();

                List<Conversation> EachConv = new List<Conversation>();

                foreach (var c in conversations)
                {
                    foreach (var u in users)
                    {
                        if (c.SenderId == existUser.Id && c.AcceptorId == u.Id || c.SenderId == u.Id && c.AcceptorId == existUser.Id)
                        {
                            EachConv.Add(c);
                        }
                    }
                }

                List<Message> newMes = new List<Message>();
                foreach (var ec in EachConv)
                {
                    foreach (var m in messages.Where(x => x.ConversationId == ec.Id).OrderByDescending(y => y.Id).Take(1))
                    {
                        if (m.IsRead == false && m.AppUserId !=existUser.Id)
                        {
                            newMes.Add(m);
                        }
                    }
                }

                ViewBag.Conv = newMes.Count();
            }


             
           
            return View(await Task.FromResult(model));
        }
    }
}
