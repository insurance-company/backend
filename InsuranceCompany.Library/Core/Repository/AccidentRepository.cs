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
        public List<Accident> GetAllByUserId(int userId)
        {
            return _context.Accidents.Include(x=>x.Car).Include(x => x.Car.Owner)
                    .Where(x => !x.Deleted && x.Car.Owner.Id == userId).ToList();
        }

        public List<Accident> GetAllUnvalidated()
        {
            return _context.Accidents.Include(x => x.Car).Include(x => x.Car.Owner)
                    .Where(x => !x.Deleted && x.Status == Model.Enum.AccidentStatus.WAITING).ToList();
        }

        public Accident Create(Accident accident)
        {
            _context.Accidents.Add(accident);
            _context.SaveChanges();
            return accident;
        }
    }
}
