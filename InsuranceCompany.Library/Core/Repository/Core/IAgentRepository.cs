using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IAgentRepository
    {
        List<Agent> GetAll();
        Agent Create(Agent agent);
        Agent? FindById(int id);
    }
}
