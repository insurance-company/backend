using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Auto : Entity
    {
        public string RegistarskiBroj { get; set; }
        public int Godiste { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public User Vlasnik {get; set; }

    }
}
