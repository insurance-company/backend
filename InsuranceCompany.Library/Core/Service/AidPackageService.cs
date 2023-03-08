﻿using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service
{
    public class AidPackageService : IAidPackageService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public AidPackageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<AidPackage> GetAll()
        {
            return _unitOfWork.AidPackageRepository.GetAll();
        }

        public AidPackage FindById(int id)
        {
            return _unitOfWork.AidPackageRepository.FindById(id);
        }
    }
}
