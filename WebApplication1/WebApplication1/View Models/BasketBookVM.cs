using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.View_Models
{
    public class BasketBookVM
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookImage { get; set; }
        public decimal BookPrice { get; set; }
        public int Count { get; set; }
    }
}
