using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface INesrecaService
    {
        List<Nesreca> GetAllByUserId(int userId);
        List<Nesreca> GetAllUnvalidated();
    }
}
