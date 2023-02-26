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
    public class AccidentService : IAccidentService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public AccidentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<Nesreca> GetAllByUserId(int userId, int pageNumber, int pageSize)
        {
            List<Nesreca> accidents = _unitOfWork.NesrecaRepository.GetAllByUserId(userId);
            Page<Nesreca> page = new Page<Nesreca>();
            page.TotalCount = accidents.Count;
            page.Data = accidents.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Page<Nesreca> GetAllUnvalidated(int pageNumber, int pageSize)
        {
            List<Nesreca> accidents = _unitOfWork.NesrecaRepository.GetAllUnvalidated();
            Page<Nesreca> page = new Page<Nesreca>();
            page.TotalCount = accidents.Count;
            page.Data = accidents.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

    }
}
