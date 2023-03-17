using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IAccidentRepository
    {
        Accident? FindById(int id);
        List<Accident> GetAll();
        List<Accident> GetAllByUserId(int userId);
        List<Accident> GetAllUnvalidated();
        Accident Create(Accident accident);
        Accident Update(Accident accident);
        Accident? FindByTowTruckIdTowingStartTimeAndDuration(int towTruckId, DateTime startTime, double duration);
    }
}
