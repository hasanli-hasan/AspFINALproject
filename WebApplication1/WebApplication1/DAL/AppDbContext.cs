using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Conversation>()
                .HasOne(m => m.Sender)
                .WithMany(m => m.SenderConversation)
                .HasForeignKey(m => m.SenderId);

            builder.Entity<Conversation>()
                .HasOne(m => m.Acceptor)
                .WithMany(m => m.AcceptorConversation)
                .HasForeignKey(m => m.AcceptorId);
        }
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
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<OurServices> OurServices { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleBook> SaleBooks { get; set; }
        public DbSet<Commet> Commets { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
    }
}
