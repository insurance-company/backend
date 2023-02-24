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
    public class PaketPomociRepository : IPaketPomociRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public PaketPomociRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<PaketPomoci> GetAll()
        {
            return _context.PaketiPomoci.Where(x => !x.Deleted).ToList();
        }
    }
}
