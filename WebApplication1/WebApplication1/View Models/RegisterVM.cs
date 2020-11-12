using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.View_Models
{
    public class RegisterVM
    {
        [Required,StringLength(100)]
        public string FullName { get; set; }

        [Required, StringLength(20)]
        public string UserName { get; set; }

        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string CheckPassword { get; set; }
    }
}
