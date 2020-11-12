using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BookCategory
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Boş buraxıla bilməz"),MaxLength(30,ErrorMessage ="30 Simvoldan Artiq Olmaz")]
        public string CategoryName { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
