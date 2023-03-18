using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IAidPackageService
    {
        Page<AidPackage> GetAll(int pageNumber, int pageSize);
        AidPackage FindById(int id);
        AidPackage Create(AidPackage package);
        AidPackage Update(AidPackage package);
        AidPackage Remove(int id);
    }
}
