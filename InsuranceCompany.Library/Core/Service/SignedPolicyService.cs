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
    public class SignedPolicyService : Core.ISignedPolicyService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public SignedPolicyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<SignedPolicy> GetAllByAgentId(int agentId, int pageNumber, int pageSize)
        {
            List<SignedPolicy> signedPolicies = _unitOfWork.SignedPolicyRepository.GetAllByAgentId(agentId);
            Page<SignedPolicy> page = new Page<SignedPolicy>();
            page.TotalCount = signedPolicies.Count;
            page.Data = signedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Page<SignedPolicy> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize)
        {
            List<SignedPolicy> signedPolicies = _unitOfWork.SignedPolicyRepository.GetAllByBuyerId(buyerId);
            Page<SignedPolicy> page = new Page<SignedPolicy>();
            page.TotalCount = signedPolicies.Count;
            page.Data = signedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public SignedPolicy BuyPolicy(SignedPolicy policy)
        {
            return _unitOfWork.SignedPolicyRepository.Create(policy);
        }
    }
}