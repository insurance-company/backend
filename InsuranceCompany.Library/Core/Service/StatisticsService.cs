using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;


namespace InsuranceCompany.Library.Core.Service
{
    public class StatisticsService : IStatisticsService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public StatisticsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<int> GetNumberOfAgentSignedPoliciesPerMonth(int agentId, int year)
        {
            List<int> retList = new();
            var allMonths = from month in Enumerable.Range(1, 12)
                            let key = new { Month = month }
                            join appointment in _unitOfWork.SignedPolicyRepository.GetAllByAgentId(agentId).Where(a => a.Date.Year == year) on key
                            equals new { appointment.Date.Month } into g
                            select new { key, total = g.Count() };
            foreach (var element in allMonths)
            {
                retList.Add(element.total);
            }
            return retList;
        }



    }
}
