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
        public List<Policy> GetAllByAgentId(int agentId)
        {
            return _context.Policies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner)
                    .Where(x => !x.Deleted && x.Agent.Id == agentId).ToList();
        }

        public List<Policy> GetAllByBuyerId(int buyerId)
        {
            return _context.Policies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner)
                    .Where(x => !x.Deleted && x.Car.Owner.Id == buyerId).ToList();
        }

        public Policy Create(Policy policy)
        {
            _context.Policies.Add(policy);
            _context.SaveChanges();
            return policy;
        }
    }
}
