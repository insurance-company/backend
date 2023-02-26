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
    public class AidPackageRepository : IAidPackageRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public AidPackageRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<PaketPomoci> GetAll()
        {
            return _context.PaketiPomoci.Where(x => !x.Deleted).ToList();
        }
    }
}
