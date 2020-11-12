using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.View_Models
{
    public class BookCreateVM
    {
        [Required(ErrorMessage ="Kitab Adi Bosh Buraxila Bilmez")]
        public string BookName { get; set; }
        [Required]
        public string BookImage { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        [Required(ErrorMessage = "Kitab Qiymeti Bosh Buraxila Bilmez")]
        public decimal BookPrice { get; set; }
        [Required]
        public int BookCount { get; set; }
        [Required]
        public string AboutBook { get; set; }
        public int AuthorId { get; set; }

        public int BookCategoryId { get; set; }

    }
}
