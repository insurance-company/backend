using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository
{
    public class TowingServiceRepository : ITowingServiceRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public TowingServiceRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<TowingService> GetAllByBranchId(int branchId)
        {
            return _context.TowingServices.Include(x => x.Branch).Where(x => !x.Deleted && x.Branch.Id == branchId).ToList();
        }
    }
}
