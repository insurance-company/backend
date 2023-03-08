using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Worker : User
    {
        [AllowNull]
        public Worker? Boss { get; set; }

    }
}
