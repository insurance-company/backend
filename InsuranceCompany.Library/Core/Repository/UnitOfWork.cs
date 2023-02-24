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
            PaketPomociRepository = new PaketPomociRepository(_context);
            FilijalaRepository = new FilijalaRepository(_context);

        }

        public IUserRepository UserRepository { get; set; }
        public IPaketPomociRepository PaketPomociRepository { get; set; }
        public IFilijalaRepository FilijalaRepository { get; set; }

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
