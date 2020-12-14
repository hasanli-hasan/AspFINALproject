using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }


        public DateTime dateTime { get; set; }
        public bool IsRead { get; set; }
        public bool IsLiked { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
