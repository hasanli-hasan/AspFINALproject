﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.View_Models
{
    public class UserVM
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public bool IsActivated { get; set; }
        public string Role { get; set; }
        public IList<string> Roles { get; set; }
        public IList<string> OtherRoles { get; set; }
    }

}