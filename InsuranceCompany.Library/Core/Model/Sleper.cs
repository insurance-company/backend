using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Sleper : Entity
    {
        public double Duzina { get; set; }
        public double Sirina { get; set; }
        public double Nosivost { get; set; }
        public SlepSluzba SlepSluzba { get; set; }

    }
}
