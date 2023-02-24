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
    public class UserRepository : IUserRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public UserRepository(InsuranceCompanyDbContext context) 
        {
            _context = context;
        }
        public List<User> GetAllBuyers()
        {
            return _context.Users.Where(x => !x.Deleted).ToList();
        }
    }
}
