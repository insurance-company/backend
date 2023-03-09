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
        List<Worker> GetAllWorkers();
        User FindByEmail(string email);
        User Create(User user);
        Manager CreateManager(Manager manager);
        Agent CreateAgent(Agent agent);
        User FindById(int id);
        Manager FindManagerById(int id);

    }
}
