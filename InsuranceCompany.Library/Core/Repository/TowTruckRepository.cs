using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;

namespace InsuranceCompany.Library.Core.Repository
{
    public class TowTruckRepository : ITowTruckRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public TowTruckRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }

        public TowTruck? FindById(int id)
        {
            return _context.TowTrucks.Find(id);
        }

        public List<TowTruck> GetAllByTowingServiceId(int id)
        {
            return _context.TowTrucks.Include(x => x.TowingService.Address).Where(x => !x.Deleted && x.TowingService.Id == id).ToList();
        }

    }
}
