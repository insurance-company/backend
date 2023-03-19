using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class TowTruck : Entity
    {
        public double Length { get; private set; }
        public double Width { get; private set; }
        public double TransportCapacity { get; private set; }
        public TowingService TowingService { get; private set; }

    }
}
