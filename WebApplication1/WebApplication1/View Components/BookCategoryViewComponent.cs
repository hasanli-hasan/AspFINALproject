using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.View_Components
{
    public class BookCategoryViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public BookCategoryViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<BookCategory> model = _db.BookCategories.ToList();
            return View(await Task.FromResult(model));
        }
    }
}
