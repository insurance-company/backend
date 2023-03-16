using InsuranceCompany.Library.Core.Model.Enum;
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
                            join appointment in _unitOfWork.PolicyRepository.GetAllByAgentId(agentId).Where(a => a.Date.Year == year) on key
                            equals new { appointment.Date.Month } into g
                            select new { key, total = g.Count() };
            foreach (var element in allMonths)
            {
                retList.Add(element.total);
            }
            return retList;
        }

        public List<int> GetNumberOfAccidentsPerMonth(int year)
        {
            List<int> retList = new();
            var allMonths = from month in Enumerable.Range(1, 12)
                            let key = new { Month = month }
                            join accident in _unitOfWork.AccidentRepository.GetAll().Where(a => a.Date.Year == year) on key
                            equals new { accident.Date.Month } into g
                            select new { key, total = g.Count() };
            foreach (var element in allMonths)
            {
                retList.Add(element.total);
            }
            return retList;
        }

        public List<int> GetNumberOfEachAccidentStatus()
        {
            List<int> retList = new();
            var statusList = new List<AccidentStatus>() { AccidentStatus.VALID, AccidentStatus.INVALID, AccidentStatus.WAITING};
            var allMonths = from status in statusList
                            let key = new { Status = status }
                            join accident in _unitOfWork.AccidentRepository.GetAll() on key
                            equals new {  accident.Status } into g
                            select new { key, total = g.Count() };
            foreach (var element in allMonths)
            {
                retList.Add(element.total);
            }
            return retList;
        }

    }
}
