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
    public class CarRepository : ICarRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public CarRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public Auto FindById(int id)
        {
            return _context.Auti.Find(id);
        }

        public List<Auto> FindAllByOwnerId(int id)
        {
            return _context.Auti.Where(x => !x.Deleted && x.Vlasnik.Id == id).ToList();
        }
    }
}
