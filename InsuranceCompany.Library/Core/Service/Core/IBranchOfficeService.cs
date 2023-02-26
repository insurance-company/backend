using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IBranchOfficeService
    {
        Page<Filijala> GetAll(int pageNumber, int pageSize);
    }
}
