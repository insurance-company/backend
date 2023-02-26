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
        public List<PotpisanaPolisa> GetAllByAgentId(int agentId)
        {
            return _context.PotpisanePolise.Include(x => x.Polisa).Include(x => x.Agent).Include(x => x.Auto.Vlasnik).Include(x => x.Polisa.PaketPomoci)
                    .Where(x => !x.Deleted && x.Agent.Id == agentId).ToList();
        }

        public List<PotpisanaPolisa> GetAllByBuyerId(int buyerId)
        {
            return _context.PotpisanePolise.Include(x => x.Polisa).Include(x => x.Agent).Include(x => x.Auto.Vlasnik).Include(x => x.Polisa.PaketPomoci)
                    .Where(x => !x.Deleted && x.Auto.Vlasnik.Id == buyerId).ToList();
        }
    }
}
