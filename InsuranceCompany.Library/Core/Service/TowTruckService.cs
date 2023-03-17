using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service
{
    public class TowTruckService : ITowTruckService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public TowTruckService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<TowTruck> GetAvailableTowTrucks(int branchId, DateTime startTime, double duration)
        {
            //prvo nadjemo sve slep sluzbe koje pripadaju odredjenoj filijali
            List<TowingService> towingServices = _unitOfWork.TowingServiceRepository.GetAllByBranchId(branchId);
            //zatim nadjemo sve slepere koji pripadaju tim slep sluzbama
            List<TowTruck> towTrucks = new();
            foreach (TowingService towingService in towingServices)
            {
                towTrucks.AddRange(_unitOfWork.TowTruckRepository.GetAllByTowingServiceId(towingService.Id));
            }
            //zatim vidimo koji su od njih slobodni
            List<TowTruck> availableTowTrucks = new();
            foreach (TowTruck towTruck in towTrucks)
            {
                if (_unitOfWork.AccidentRepository.FindByTowTruckIdTowingStartTimeAndDuration(towTruck.Id, startTime, duration) == null) availableTowTrucks.Add(towTruck);
            }

            return availableTowTrucks;
        }
    }
}
