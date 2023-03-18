using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;

namespace InsuranceCompany.Library.Core.Repository
{
    public class AccidentRepository : IAccidentRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public AccidentRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }

        public List<Accident> GetAll()
        {
            return _context.Accidents.Include(x => x.Car).Include(x => x.Car.Owner).Where(x => !x.Deleted).ToList();
        }

        public List<Accident> GetAllByUserId(int userId)
        {
            return _context.Accidents.Include(x => x.Car).Include(x => x.Car.Owner)
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

        public Accident Update(Accident accident)
        {
            _context.Accidents.Update(accident);
            return accident;
        }

        public Accident? FindByTowTruckIdTowingStartTimeAndDuration(int towTruckId, DateTime startTime, double duration)
        {
            DateTime endTime = startTime.AddHours(duration);

            return _context.Accidents.FirstOrDefault(x => x.TowTruck.Id == towTruckId & (
            (x.TowingStartTime >= startTime && x.TowingStartTime.AddHours(x.TowingDuration) <= endTime) ||
            (x.TowingStartTime > startTime && x.TowingStartTime < endTime) || 
            (x.TowingStartTime.AddHours(x.TowingDuration) > startTime && x.TowingStartTime.AddHours(x.TowingDuration) < endTime)
            ));
        }

        public Accident? FindById(int id)
        {
            return _context.Accidents.FirstOrDefault(x => x.Id == id);
        }
    }
}
