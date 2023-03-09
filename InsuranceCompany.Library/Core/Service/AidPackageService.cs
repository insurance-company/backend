using InsuranceCompany.Library.Core.Model;
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
        public AidPackage Create(AidPackage package)
        {
            try
            {
                _unitOfWork.AidPackageRepository.Create(package);
                _unitOfWork.Save();
                return package;
            } 
            catch
            {
                throw new Exception();
            }
        }

        public AidPackage Update(AidPackage package)
        {
            try
            {
                _unitOfWork.AidPackageRepository.Update(package);
                _unitOfWork.Save();
                return package;
            }
            catch
            {
                throw new Exception();
            }
        }

        public AidPackage Remove(int id)
        {
            try
            {
                AidPackage package = FindById(id);
                _unitOfWork.AidPackageRepository.Remove(package);
                _unitOfWork.Save();
                return package;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
