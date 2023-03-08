using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface ISignedPolicyService
    {
        Page<SignedPolicy> GetAllByAgentId(int agentId, int pageNumber, int pageSize);
        Page<SignedPolicy> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize);
        SignedPolicy BuyPolicy(SignedPolicy policy);
    }
}
