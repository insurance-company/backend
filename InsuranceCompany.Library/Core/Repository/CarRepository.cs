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
        public Car? FindById(int id)
        {
            return _context.Cars.Find(id);
        }

        public List<Car> FindAllByOwnerId(int id)
        {
            return _context.Cars.Where(x => !x.Deleted && x.Owner.Id == id).ToList();
        }

        public Car Create(Car car)
        {
            _context.Cars.Add(car);
            return car;
        }

        public Car Update(Car car)
        {
            _context.Cars.Update(car);
            return car;
        }

        public Car Remove(Car car)
        {
            _context.Cars.Remove(car);
            return car;
        }
    }
}
