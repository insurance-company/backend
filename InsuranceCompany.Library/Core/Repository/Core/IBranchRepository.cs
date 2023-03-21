using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IBranchRepository
    {
        List<Branch> GetAll();
        Branch FindById(int id);
        Branch Create(Branch branch);
        Branch Update(Branch branch);
        Branch Remove(Branch branch);
    }
}
