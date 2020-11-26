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

namespace WebApplication1.Areas.AdminP.Controllers
{
    [Area("AdminP")]
    public class SaleController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public SaleController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Sales.Where(x=>x.isRecived==false).Count() / 3);
            ViewBag.Page = page;

            if (page == null)
            {
                List<Sale> sales = _db.Sales.Where(x => x.isRecived == false).OrderByDescending(x=>x.Id).Take(3).ToList();
                List<SaleVM> saleVMs = new List<SaleVM>();

                foreach (Sale sale in sales)
                {
                    AppUser user = await _userManager.FindByIdAsync(sale.AppUserId);

                    SaleVM saleVM = new SaleVM
                    {
                        Id = sale.Id,
                        Date = sale.Date,
                        Total = sale.Total,
                        Email = user.Email,
                        FullName = user.FullName,
                        SaleBooks = _db.SaleBooks.Where(sb => sb.SaleId == sale.Id).Include(sb => sb.Book).ToList(),
                        Number = sale.Number,
                        Message = sale.Message,
                        Address = sale.Address,
                        isRecived = sale.isRecived
                    };

                    if (!saleVM.isRecived)
                    {
                        saleVMs.Add(saleVM);
                    }

                }

                return View(saleVMs);
            }
            else
            {
                List<Sale> sales = _db.Sales.Where(x => x.isRecived == false).OrderByDescending(x => x.Id).Skip(((int)page - 1) * 3).Take(3).ToList();
                List<SaleVM> saleVMs = new List<SaleVM>();

                foreach (Sale sale in sales)
                {
                    AppUser user = await _userManager.FindByIdAsync(sale.AppUserId);

                    SaleVM saleVM = new SaleVM
                    {
                        Id = sale.Id,
                        Date = sale.Date,
                        Total = sale.Total,
                        Email = user.Email,
                        FullName = user.FullName,
                        SaleBooks = _db.SaleBooks.Where(sb => sb.SaleId == sale.Id).Include(sb => sb.Book).ToList(),
                        Number = sale.Number,
                        Message = sale.Message,
                        Address = sale.Address,
                        isRecived = sale.isRecived
                    };

                    if (!saleVM.isRecived)
                    {
                        saleVMs.Add(saleVM);
                    }

                }

                return View(saleVMs);
            }
           
           
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            Sale sale = _db.Sales.Include(x=>x.AppUser).Include(b=>b.SaleBooks).Where(s=>s.Id==id).FirstOrDefault();

            SaleVM saleVM = new SaleVM
            {
                Id = sale.Id,
                Date = sale.Date,
                Total = sale.Total,
                Email = sale.AppUser.Email,
                FullName = sale.AppUser.FullName,
                Number = sale.Number,
                Message = sale.Message,
                Address = sale.Address,
                isRecived=sale.isRecived,
                SaleBooks = _db.SaleBooks.Where(x => x.SaleId == sale.Id).Include(b => b.Book).ToList()
            };


            return View(saleVM);
        }

        public async Task<IActionResult> ArchiveSale(int? id)
        {
            if (id == null) return NotFound();
            Sale sale = await _db.Sales.FindAsync(id);
           
            sale.isRecived = true;
           await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RecivedSales()
        {
            List<Sale> sales = _db.Sales.ToList();
            List<SaleVM> saleVMs = new List<SaleVM>();

            foreach (Sale sale in sales)
            {
                AppUser user = await _userManager.FindByIdAsync(sale.AppUserId);

                SaleVM saleVM = new SaleVM
                {
                    Id = sale.Id,
                    Date = sale.Date,
                    Total = sale.Total,
                    Email = user.Email,
                    FullName = user.FullName,
                    SaleBooks = _db.SaleBooks.Where(sb => sb.SaleId == sale.Id).Include(sb => sb.Book).ToList(),
                    Number = sale.Number,
                    Message = sale.Message,
                    Address = sale.Address,
                    isRecived = sale.isRecived
                };

                if (saleVM.isRecived)
                {
                    saleVMs.Add(saleVM);
                }

            }

            return View(saleVMs);
        }

    }
}