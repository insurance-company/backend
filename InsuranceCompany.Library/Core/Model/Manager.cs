using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Manager : Worker
    {
        public Branch ManagesTheBranch { get; set; }
    }
}
