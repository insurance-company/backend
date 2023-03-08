using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository
{
    public class SignedPolicyRepository : ISignedPolicyRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public SignedPolicyRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<SignedPolicy> GetAllByAgentId(int agentId)
        {
            return _context.SignedPolicies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner)
                    .Where(x => !x.Deleted && x.Agent.Id == agentId).ToList();
        }

        public List<SignedPolicy> GetAllByBuyerId(int buyerId)
        {
            return _context.SignedPolicies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner)
                    .Where(x => !x.Deleted && x.Car.Owner.Id == buyerId).ToList();
        }

        public SignedPolicy Create(SignedPolicy policy)
        {
            _context.SignedPolicies.Add(policy);
            _context.SaveChanges();
            return policy;
        }
    }
}
