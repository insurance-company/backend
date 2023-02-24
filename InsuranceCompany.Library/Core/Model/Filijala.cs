using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Filijala : Entity
    {
        public Agencija Agencija { get; set; }
        public string Adresa { get; set; }

    }
}
