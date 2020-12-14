using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.View_Models
{
    public class ChatVM
    {
        public List<AppUser> Users { get; set; }
        public List<Message> Messages { get; set; }
        public List<Conversation> EachConv { get; set; }
        public List<Conversation> Conversations { get; set; }

        //mesajin contenti ucun
        public string Content { get; set; }

        public string AcceptorUser { get; set; }
    }
}
