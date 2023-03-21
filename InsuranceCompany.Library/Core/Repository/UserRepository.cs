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
        public List<User> GetAllCustomers()
        {
            return _context.Users.Where(x => !x.Deleted && x.Role == Model.Enum.Role.CUSTOMER.ToString()).ToList();
        }

        public List<Worker> GetAllWorkers()
        {
            return _context.Workers.Where(x => !x.Deleted).ToList();
        }

        public User FindByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }


        public User FindById(int id)
        {
            return _context.Users.Include(x => x.Address).FirstOrDefault(x => x.Id == id);
        }

    }
}
