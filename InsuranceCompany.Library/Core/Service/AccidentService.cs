using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;


namespace InsuranceCompany.Library.Core.Service
{
    public class AccidentService : IAccidentService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public AccidentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<Accident> GetAllByUserId(int userId, int pageNumber, int pageSize)
        {
            List<Accident> accidents = _unitOfWork.AccidentRepository.GetAllByUserId(userId);
            Page<Accident> page = new Page<Accident>();
            page.TotalCount = accidents.Count;
            page.Data = accidents.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Page<Accident> GetAllUnvalidated(int pageNumber, int pageSize)
        {
            List<Accident> accidents = _unitOfWork.AccidentRepository.GetAllUnvalidated();
            Page<Accident> page = new Page<Accident>();
            page.TotalCount = accidents.Count;
            page.Data = accidents.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Accident Create(Accident accident)
        {
            try
            {
                Accident ret = _unitOfWork.AccidentRepository.Create(accident);
                _unitOfWork.Save();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Accident Update(Accident acc)
        {
            try
            {
                Accident accident = _unitOfWork.AccidentRepository.FindById(acc.Id);
                accident.Validate(acc.Status, acc.TowTruck, acc.TowingStartTime, acc.TowingDuration);
                _unitOfWork.AccidentRepository.Update(accident);
                _unitOfWork.Save();
                return accident;
            }
            catch(Exception e)
            {
                throw new Exception();
            }
        }

    }
}
