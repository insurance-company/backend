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
        Page<PotpisanaPolisa> GetAllByAgentId(int agentId, int pageNumber, int pageSize);
        Page<PotpisanaPolisa> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize);
    }
}
