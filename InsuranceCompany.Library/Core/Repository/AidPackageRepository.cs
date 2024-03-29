﻿using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository
{
    public class AidPackageRepository : IAidPackageRepository
    {
        private readonly InsuranceCompanyDbContext _context;
        public AidPackageRepository(InsuranceCompanyDbContext context)
        {
            _context = context;
        }
        public List<AidPackage> GetAll()
        {
            return _context.AidPackages.Where(x => !x.Deleted).ToList();
        }

        public AidPackage? FindById(int id)
        {
            return _context.AidPackages.FirstOrDefault(x => x.Id == id);
        }

        public AidPackage Create(AidPackage aidPackage)
        {
            _context.AidPackages.Add(aidPackage);
            return aidPackage;
        }

        public AidPackage Update(AidPackage aidPackage)
        {
            _context.AidPackages.Update(aidPackage);
            return aidPackage;
        }

        public AidPackage Remove(AidPackage aidPackage)
        {
            _context.AidPackages.Remove(aidPackage);
            return aidPackage;
        }
    }
}
