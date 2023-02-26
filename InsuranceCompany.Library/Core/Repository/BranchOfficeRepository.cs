using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository
{
    public class BranchOfficeRepository : IBranchOfficeRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public BranchOfficeRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<Filijala> GetAll()
        {
            return _context.Filijale.Where(x => !x.Deleted).ToList();
        }
    }
}
