using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IUserRepository
    {
        List<User> GetAllBuyers();
        User FindByEmail(string email);
        User Create(User user);
        Manager CreateManager(Manager manager);
        User FindById(int id);
        Manager FindManagerById(int id);

    }
}
