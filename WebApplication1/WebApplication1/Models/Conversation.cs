using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Conversation
    {
        public string Id { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }
        [ForeignKey("Acceptor")]
        public string AcceptorId { get; set; }

        public AppUser Sender { get; set; }
        public AppUser Acceptor { get; set; }
    }
}
