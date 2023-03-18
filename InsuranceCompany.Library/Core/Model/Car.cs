using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Car : Entity
    {
        public string RegisterNumber { get; private set; }
        public int Years { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public User Owner {get; private set; }

    }
}
