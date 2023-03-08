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
    public class BranchRepository : IBranchOfficeRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public BranchRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<Branch> GetAll()
        {
            return _context.Branches.Where(x => !x.Deleted).ToList();
        }
    }
}
