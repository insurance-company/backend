using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IPolicyService
    {
        Page<SignedPolicy> GetAllByAgentId(int agentId, int pageNumber, int pageSize);
        Page<SignedPolicy> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize);
        SignedPolicy BuyPolicy(SignedPolicy policy);
        Page<SignedPolicy> GetAllUnsigned(int pageNumber, int pageSize);
        void SignOrDecline(int policyId, bool sign, int agentId);
    }
}
