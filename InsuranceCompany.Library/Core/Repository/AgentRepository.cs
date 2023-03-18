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
    public class AgentRepository : IAgentRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public AgentRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }

        public Agent? FindById(int id)
        {
            return _context.Agents.Include(x => x.WorksInBranch).FirstOrDefault(x => x.Id == id);
        }

        public Agent Create(Agent agent)
        {
            _context.Agents.Add(agent);
            _context.SaveChanges();
            return agent;
        }

        public List<Agent> GetAll()
        {
            return _context.Agents.Where(x => !x.Deleted).ToList();
        }

    }
}
