using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SaleBook
    {
        public int Id { get; set; }
        public decimal BookPrice { get; set; }
        public int Count { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
