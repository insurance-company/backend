using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class TowTruck : Entity
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double TransportCapacity { get; set; }
        public TowingService TowingService { get; set; }

    }
}
