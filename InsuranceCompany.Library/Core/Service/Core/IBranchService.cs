using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IBranchService
    {
        Page<Branch> GetAll(int pageNumber, int pageSize);
        List<Branch> GetAllWithoutPagination();
        Branch FindById(int id);
        Branch Create(Branch branch);
        Branch Update(Branch branch);
        Branch Remove(int id);
    }
}
