using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.View_Models
{
    public class HomeVM
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
        public RecommendationBook RecommendationBook { get; set; }
        public IEnumerable<DiscountBooks> DiscountBooks { get; set; }
        public DiscountText DiscountText { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }
        public IEnumerable<AuthorAbout> AuthorAbouts { get; set; }
        public IEnumerable<BookSlider> BookSliders { get; set; }
        public IEnumerable<MRClassics> MRClassics { get; set; }
        public IEnumerable<SpecialBooks> SpecialBooks { get; set; }
       
    }
}
