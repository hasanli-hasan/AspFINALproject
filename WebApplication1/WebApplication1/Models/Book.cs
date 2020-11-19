using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookImage { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public decimal BookPrice { get; set; }
        public int BookCount { get; set; }
        public string AboutBook { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }

        public ICollection<SaleBook> SaleBooks { get; set; }
    }
}
