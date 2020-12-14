using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{

    public interface IEmailService
    {
        Task SendEmailAsync(List<string> email, string subject, string message);
    }
}
