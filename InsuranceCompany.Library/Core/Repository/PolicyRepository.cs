using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public PolicyRepository(InsuranceCompanyDbContext context)
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

        public SignedPolicy Update(SignedPolicy policy)
        {
            _context.SignedPolicies.Update(policy);
            return policy;
        }

        public List<SignedPolicy> GetAllUnsigned()
        {
            return _context.SignedPolicies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner).Where(x => !x.Deleted && x.Agent == null).ToList();
        }

        public SignedPolicy? FindById(int id)
        {
            return _context.SignedPolicies.Include(x => x.Car.Owner).Include(x => x.AidPackage).Include(x => x.Agent).FirstOrDefault(x => x.Id == id);
        }

        public List<SignedPolicy> GetAllValidByCustomer(int customerId)
        {
            DateTime now = DateTime.Now;
            return _context.SignedPolicies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner).Where(x => !x.Deleted && x.Car.Owner.Id == customerId && x.Agent != null && x.Date.AddMonths(x.AidPackage.DurationInMonths) > now).ToList();
        }
    }
}
