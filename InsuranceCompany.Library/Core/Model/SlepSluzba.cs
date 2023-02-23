using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class SlepSluzba : Entity
    {
        public string Adresa { get; set; }
        public Filijala Filijala { get; set; }

    }
}
