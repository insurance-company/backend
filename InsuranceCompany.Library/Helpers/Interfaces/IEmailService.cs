﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Helpers.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string subject, string text, string sendTo);
    }
}
