using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service
{
    public class PolicyService : Core.IPolicyService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public PolicyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<SignedPolicy> GetAllByAgentId(int agentId, int pageNumber, int pageSize)
        {
            List<SignedPolicy> signedPolicies = _unitOfWork.PolicyRepository.GetAllByAgentId(agentId);
            Page<SignedPolicy> page = new Page<SignedPolicy>();
            page.TotalCount = signedPolicies.Count;
            page.Data = signedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Page<SignedPolicy> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize)
        {
            List<SignedPolicy> signedPolicies = _unitOfWork.PolicyRepository.GetAllByBuyerId(buyerId);
            Page<SignedPolicy> page = new Page<SignedPolicy>();
            page.TotalCount = signedPolicies.Count;
            page.Data = signedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public SignedPolicy BuyPolicy(SignedPolicy policy)
        {
            return _unitOfWork.PolicyRepository.Create(policy);
        }

        public Page<SignedPolicy> GetAllUnsigned(int pageNumber, int pageSize)
        {
            List<SignedPolicy> unsignedPolicies = _unitOfWork.PolicyRepository.GetAllUnsigned();
            Page<SignedPolicy> page = new Page<SignedPolicy>();
            page.TotalCount = unsignedPolicies.Count;
            page.Data = unsignedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }
    }
}