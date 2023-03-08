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
        List<Accident> GetAllByUserId(int userId);
        List<Accident> GetAllUnvalidated();
        Accident Create(Accident accident);
    }
}
