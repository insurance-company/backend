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
        Policy FindById(int aidPackageId, int carId);
        Page<Policy> GetAllByAgentId(int agentId, int pageNumber, int pageSize);
        Page<Policy> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize);
        Policy BuyPolicy(Policy policy);
        Page<Policy> GetAllUnsigned(int pageNumber, int pageSize);
        void SignOrDecline(int aidPackageId,int carId, bool sign, int agentId);
        List<Policy> GetAllValidByCustomer(int customerId);
    }
}
