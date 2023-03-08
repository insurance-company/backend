using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Car : Entity
    {
        public string RegisterNumber { get; set; }
        public int Years { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public User Owner {get; set; }

    }
}
