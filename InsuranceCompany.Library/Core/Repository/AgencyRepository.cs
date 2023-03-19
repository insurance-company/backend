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
    public class AgencyRepository : IAgencyRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public AgencyRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public Agency? GetFirstOrDefault()
        {
            return _context.Agencies.FirstOrDefault();
        }
    }
}
