using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<RecommendationBook> RecommendationBooks { get; set; }
        public DbSet<DiscountBooks> DiscountBooks { get; set; }
        public DbSet<DiscountText> DiscountTexts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AuthorAbout> AuthorAbouts { get; set; }
        public DbSet<BookSlider> BookSliders { get; set; }
        public DbSet<MRClassics> MRClassics { get; set; }
        public DbSet<SpecialBooks> SpecialBooks { get; set; }

    }
}
