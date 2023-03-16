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
        List<SignedPolicy> GetAllByAgentId(int agentId);
        List<SignedPolicy> GetAllByBuyerId(int buyerId);
        SignedPolicy Create(SignedPolicy policy);
        SignedPolicy Update(SignedPolicy policy);
        List<SignedPolicy> GetAllUnsigned();
        SignedPolicy FindById(int id);
    }
}
