using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookImage { get; set; }
        public decimal BookPrice { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
