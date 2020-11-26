using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Commet
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }    
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public bool isAppend { get; set; }
        public string CommentImage { get; set; }
    }
}
