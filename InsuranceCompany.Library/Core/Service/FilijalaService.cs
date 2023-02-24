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
    public class FilijalaService : IFilijalaService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public FilijalaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Filijala> GetAll()
        {
            return _unitOfWork.FilijalaRepository.GetAll();
        }
    }
}
