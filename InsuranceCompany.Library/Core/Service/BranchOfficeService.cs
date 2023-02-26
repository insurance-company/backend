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
    public class BranchOfficeService : IBranchOfficeService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BranchOfficeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<Filijala> GetAll(int pageNumber, int pageSize)
        {
            List<Filijala> filijale = _unitOfWork.FilijalaRepository.GetAll();
            Page<Filijala> page = new Page<Filijala>();
            page.TotalCount = filijale.Count;
            page.Data = filijale.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }
    }
}
