using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface ITowTruckService
    {
        List<TowTruck> GetAvailableTowTrucks(int branchId, DateTime startTime, double duration);
    }
}
