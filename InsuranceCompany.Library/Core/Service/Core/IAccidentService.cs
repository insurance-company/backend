using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IAccidentService
    {
        Page<Nesreca> GetAllByUserId(int userId, int pageNumber, int pageSize);
        Page<Nesreca> GetAllUnvalidated(int pageNumber, int pageSize);
    }
}
