using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Nesreca : Entity
    {
        public int Opis { get; set; }
        public DateTime Datum { get; set; }
        public Auto Auto { get; set; }  
        public Sleper Sleper { get; set; }
    }
}
