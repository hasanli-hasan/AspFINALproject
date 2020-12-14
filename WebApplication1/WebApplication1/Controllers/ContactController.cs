using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Subscribe([FromForm] string email)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            bool existSubscription = _context.Subscriptions.Any(e => e.Email == email);
            if (existSubscription)
            {
                return Ok(existSubscription);
            }

            Subscriptions subscription = new Subscriptions { Email = email };
            await _context.Subscriptions.AddAsync(subscription);
            await _context.SaveChangesAsync();

            return Ok(existSubscription);
        }
    }
}