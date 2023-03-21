using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IPolicyRepository
    {
        List<Policy> GetAllByAgentId(int agentId);
        List<Policy> GetAllByBuyerId(int buyerId);
        Policy Create(Policy policy);
        Policy Update(Policy policy);
        List<Policy> GetAllUnsigned();
        Policy? FindById(int id);
        List<Policy> GetAllValidByCustomer(int customerId);
    }
}
