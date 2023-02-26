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
        List<Nesreca> GetAllByUserId(int userId);
        List<Nesreca> GetAllUnvalidated();
    }
}
