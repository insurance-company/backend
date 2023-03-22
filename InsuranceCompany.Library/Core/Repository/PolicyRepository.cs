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

        public Policy Update(Policy policy)
        {
            _context.Policies.Update(policy);
            return policy;
        }

        public List<Policy> GetAllUnsigned()
        {
            return _context.Policies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner).Where(x => !x.Deleted && x.Agent == null).ToList();
        }

        public Policy? FindById(int aidPackageid, int carId)
        {
            return _context.Policies.Include(x => x.Car.Owner).Include(x => x.AidPackage).Include(x => x.Agent).FirstOrDefault(x => x.AidPackageId == aidPackageid && x.CarId == carId && !x.Deleted);
        }

        public List<Policy> GetAllValidByCustomer(int customerId)
        {
            DateTime now = DateTime.Now;
            return _context.Policies.Include(x => x.AidPackage).Include(x => x.Agent).Include(x => x.Car.Owner).Where(x => !x.Deleted && x.Car.Owner.Id == customerId && x.Agent != null && x.Date.AddMonths(x.AidPackage.DurationInMonths) > now).ToList();
        }

        public Policy Remove(Policy policy)
        {
            _context.Policies.Remove(policy);
            return policy;
        }
    }
}
