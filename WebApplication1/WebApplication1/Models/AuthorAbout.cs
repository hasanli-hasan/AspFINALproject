using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AuthorAbout
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Image { get; set; }
        public string FrontTitle { get; set; }
        public string About { get; set; }
        public string BookInfo { get; set; }
    }
}
