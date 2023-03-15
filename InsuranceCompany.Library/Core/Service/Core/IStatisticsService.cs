using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface IStatisticsService
    {
        List<int> GetNumberOfAgentSignedPoliciesPerMonth(int agentId, int year);
    }
}
