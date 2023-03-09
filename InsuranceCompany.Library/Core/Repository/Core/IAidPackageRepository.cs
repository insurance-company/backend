using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IAidPackageRepository
    {
        List<AidPackage> GetAll();
        AidPackage FindById(int id);
        AidPackage Create(AidPackage aidPackage);
        AidPackage Update(AidPackage aidPackage);
        AidPackage Remove(AidPackage aidPackage);
    }
}
