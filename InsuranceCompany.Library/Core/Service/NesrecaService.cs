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
    public class NesrecaService : INesrecaService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public NesrecaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Nesreca> GetAllByUserId(int userId)
        {
            return _unitOfWork.NesrecaRepository.GetAllByUserId(userId);
        }

        public List<Nesreca> GetAllUnvalidated()
        {
            return _unitOfWork.NesrecaRepository.GetAllUnvalidated();
        }

    }
}
