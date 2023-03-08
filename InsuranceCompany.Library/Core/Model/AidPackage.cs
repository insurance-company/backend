using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class AidPackage : Entity
    {
        public int DurationInMonths { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Cover { get; set; }

    }
}
