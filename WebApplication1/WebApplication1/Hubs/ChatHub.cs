using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class ChatHub:Hub
    {
        //private readonly UserManager<AppUser> _userManager;
        //private readonly AppDbContext _db;
        //public ChatHub(UserManager<AppUser> userManager, AppDbContext db)
        //{
        //    _userManager = userManager;
        //    _db = db;
        //}

        //public override Task OnConnectedAsync()
        //{
        //    var token = Context.GetHttpContext().Request.Cookies["token"];

        //    AppUser user = _db.Users.FirstOrDefault(u => u.Token == token);

        //    user.ConnectionId = Context.ConnectionId;
        //    _db.SaveChanges();

        //    return base.OnConnectedAsync();
        //}

        //public override Task OnDisconnectedAsync(Exception exception)
        //{
        //    var token = Context.GetHttpContext().Request.Cookies["token"];

        //    AppUser user = _db.Users.FirstOrDefault(u => u.Token == token);

        //    user.ConnectionId = null;
        //    _db.SaveChanges();

        //    return base.OnDisconnectedAsync(exception);
        //}
        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}
    }
}
