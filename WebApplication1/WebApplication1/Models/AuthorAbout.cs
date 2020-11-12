using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AuthorAbout
    {
        public int Id { get; set; }
        [Required]
        public string NameSurname { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        [MaxLength(100)]
        public string FrontTitle { get; set; }

        [Required]
        public string About { get; set; }
        [Required]
        public string BookInfo { get; set; }
    }
}
