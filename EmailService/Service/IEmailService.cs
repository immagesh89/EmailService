using EmailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService.Service
{
    public interface IEmailService
    {
        public void SendEmail(EmailModel emailmodel);
    }
}
