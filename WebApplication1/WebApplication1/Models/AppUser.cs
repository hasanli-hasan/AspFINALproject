using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AppUser:IdentityUser
    {
        [Required,StringLength(100)]
        public string FullName { get; set; }
        public bool IsActivated { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Commet> Commets { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
    }
}
