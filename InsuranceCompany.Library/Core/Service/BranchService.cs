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
    public class BranchService : IBranchService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BranchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<Branch> GetAll(int pageNumber, int pageSize)
        {
            List<Branch> branches = _unitOfWork.BranchRepository.GetAll();
            Page<Branch> page = new Page<Branch>();
            page.TotalCount = branches.Count;
            page.Data = branches.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public List<Branch> GetAllWithoutPagination()
        {
            return _unitOfWork.BranchRepository.GetAll();
        }

        public Branch FindById(int id)
        {
            return _unitOfWork.BranchRepository.FindById(id);
        }

        public Branch Create(Branch branch)
        {
          
                Branch ret = _unitOfWork.BranchRepository.Create(branch);
                _unitOfWork.Save();
                return ret;
           
        }

        public Branch Update(Branch branch)
        {
            try
            {
                Branch ret = _unitOfWork.BranchRepository.Update(branch);
                _unitOfWork.Save();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Branch Remove(int id)
        {
            try
            {
                Branch branch = FindById(id);
                branch.Deleted = true;
                Branch ret = _unitOfWork.BranchRepository.Update(branch);
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
