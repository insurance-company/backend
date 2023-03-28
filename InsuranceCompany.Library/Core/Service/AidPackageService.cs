using Aspose.Pdf;
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
        public Page<AidPackage> GetAll(int pageNumber, int pageSize)
        {
            List<AidPackage> packages = _unitOfWork.AidPackageRepository.GetAll();
            Page<AidPackage> page = new Page<AidPackage>();
            page.TotalCount = packages.Count;
            page.Data = packages.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public AidPackage FindById(int id)
        {
            return _unitOfWork.AidPackageRepository.FindById(id);
        }
        public AidPackage Create(AidPackage package)
        {
            try
            {
                AidPackage ret =_unitOfWork.AidPackageRepository.Create(package);
                _unitOfWork.Save();
                return ret;
            } 
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public AidPackage Update(AidPackage package)
        {
            try
            {
                AidPackage ret = _unitOfWork.AidPackageRepository.Update(package);
                _unitOfWork.Save();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AidPackage Remove(int id)
        {
            try
            {
                AidPackage package = FindById(id);
                package.Deleted = true;
                AidPackage ret = _unitOfWork.AidPackageRepository.Update(package);
                _unitOfWork.Save();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
