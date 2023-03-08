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
    public class BranchService : IBranchOfficeService
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
    }
}
