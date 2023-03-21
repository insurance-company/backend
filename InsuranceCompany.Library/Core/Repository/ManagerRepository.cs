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
    public class ManagerRepository : IManagerRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public ManagerRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }

        public Manager Create(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
            return manager;
        }

        public Manager Update(Manager manager)
        {
            _context.Managers.Update(manager);
            return manager;
        }

        public Manager? FindById(int id)
        {
            return _context.Managers.Include(x => x.WorksInBranch).FirstOrDefault(x => x.Id == id);
        }
    }
}
