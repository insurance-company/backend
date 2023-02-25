using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IUserService
    {
        List<User> GetAllBuyers();
        User FindByEmail(string email);
        User Register(User user);
        User FindById(int id);
    }
}
