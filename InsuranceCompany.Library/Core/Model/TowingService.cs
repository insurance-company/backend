using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class TowingService : Entity
    {
        public string Address { get; private set; }
        public Branch Branch { get; private set; }

    }
}
