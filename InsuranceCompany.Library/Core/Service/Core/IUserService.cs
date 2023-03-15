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
        List<Worker> GetAllWorkers();
        List<Agent> GetAllAgents();
        User FindByEmail(string email);
        User RegisterCustomer(User user);
        Manager RegisterManager(Manager user);
        Agent RegisterAgent(Agent agent);
        User FindById(int id);
        Manager FindManagerById(int id);
    }
}
