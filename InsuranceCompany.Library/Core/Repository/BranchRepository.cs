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
    public class BranchRepository : IBranchRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public BranchRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<Branch> GetAll()
        {
            return _context.Branches.Include(x => x.Address).Include(x => x.Agency).Where(x => !x.Deleted).ToList();
        }
        public Branch FindById(int id)
        {
            return _context.Branches.Include(x => x.Address).Include(x => x.Agency).FirstOrDefault(x => x.Id == id);
        }

        public Branch Create(Branch branch)
        {
            _context.Branches.Add(branch);
            return branch;
        }

        public Branch Update(Branch branch)
        {
            _context.Branches.Update(branch);
            return branch;
        }

        public Branch Remove(Branch branch)
        {
            _context.Branches.Remove(branch);
            return branch;
        }
    }
}
