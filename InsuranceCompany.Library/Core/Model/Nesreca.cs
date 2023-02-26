using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Nesreca : Entity
    {
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public Auto Auto { get; set; }
        public Sleper? Sleper { get; set; }
        public StatusNesrece Status { get; set; }
    }
}
