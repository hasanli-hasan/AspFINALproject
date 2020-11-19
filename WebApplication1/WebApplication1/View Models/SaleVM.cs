using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.View_Models
{
    public class SaleVM
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public List<SaleBook> SaleBooks { get; set; }
        public string Number { get; set; }
        public string Message { get; set; }
        public string Address { get; set; }
        public bool isRecived { get; set; }
    }
}
