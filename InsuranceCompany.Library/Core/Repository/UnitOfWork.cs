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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InsuranceCompanyDbContext _context;
        private Dictionary<string, dynamic> _repositories;

        public UnitOfWork(InsuranceCompanyDbContext context)
        {
            _context = context;

            UserRepository = new UserRepository(_context);
            AidPackageRepository = new AidPackageRepository(_context);
            BranchRepository = new BranchRepository(_context);
            AccidentRepository = new AccidentRepository(_context);
            SignedPolicyRepository = new SignedPolicyRepository(_context);
            CarRepository = new CarRepository(_context);
        }

        public IUserRepository UserRepository { get; set; }
        public IAidPackageRepository AidPackageRepository { get; set; }
        public IBranchRepository BranchRepository { get; set; }
        public IAccidentRepository AccidentRepository { get; set; }
        public ISignedPolicyRepository SignedPolicyRepository { get; set; }
        public ICarRepository CarRepository { get; set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
