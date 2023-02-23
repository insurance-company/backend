using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class PotpisanaPolisa : Entity
    {
        public Polisa Polisa { get; set; }
        public Agent Agent { get; set; }
        public Auto Auto { get; set; }
    }
}
