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
    public class AccidentRepository : IAccidentRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public AccidentRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<Nesreca> GetAllByUserId(int userId)
        {
            return _context.Nesrece.Include(x=>x.Auto).Include(x => x.Auto.Vlasnik)
                    .Where(x => !x.Deleted && x.Auto.Vlasnik.Id == userId).ToList();
        }

        public List<Nesreca> GetAllUnvalidated()
        {
            return _context.Nesrece.Include(x => x.Auto).Include(x => x.Auto.Vlasnik)
                    .Where(x => !x.Deleted && x.Status == Model.Enum.StatusNesrece.CEKANAVALIDACIJU).ToList();
        }
    }
}
