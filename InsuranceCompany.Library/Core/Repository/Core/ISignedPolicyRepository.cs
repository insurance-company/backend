using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface ISignedPolicyRepository
    {
        List<PotpisanaPolisa> GetAllByAgentId(int agentId);
        List<PotpisanaPolisa> GetAllByBuyerId(int buyerId);
    }
}
