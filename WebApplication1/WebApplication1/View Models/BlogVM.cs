using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.View_Models
{
    public class BlogVM
    {
        public int Id { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        [MaxLength(80)]
        public string FrontText { get; set; }
        public string BlogText { get; set; }
        public DateTime DateTime { get; set; }

        public BlogCategory BlogCategory { get; set; }
        public ICollection<Commet> Commets { get; set; }

        public string Text { get; set; }
        public DateTime ComDate { get; set; }
        public string UserName { get; set; }
       
    }
}
