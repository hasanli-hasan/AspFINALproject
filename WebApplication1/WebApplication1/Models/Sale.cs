using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public ICollection<SaleBook> SaleBooks { get; set; }

        public string Number { get; set; }
        public string Message { get; set; }
        public string Address { get; set; }
        public bool  isRecived { get; set; }
    }
}
