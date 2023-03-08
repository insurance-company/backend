using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Branch : Entity
    {
        public Agency Agency { get; set; }
        public string Address { get; set; }

    }
}
