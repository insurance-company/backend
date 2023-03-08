using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface ICarRepository
    {
        Car FindById(int id);
        List<Car> FindAllByOwnerId(int id);
    }
}
