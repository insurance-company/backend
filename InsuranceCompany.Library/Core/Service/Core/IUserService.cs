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
        Page<User> GetAllBuyers(int pageNumber, int pageSize);
        User FindByEmail(string email);
        User RegisterCustomer(User user);
        User FindById(int id);
    }
}
