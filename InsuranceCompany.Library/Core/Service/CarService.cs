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
    public class CarService : ICarService
    {

        protected readonly IUnitOfWork _unitOfWork;
        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Car FindById(int id)
        {
            return _unitOfWork.CarRepository.FindById(id);
        }

        public List<Car> FindAllByOwnerId(int id)
        {
            return _unitOfWork.CarRepository.FindAllByOwnerId(id);
        }

        public Car Create(Car car)
        {
            try
            {
                Car ret = _unitOfWork.CarRepository.Create(car);
                _unitOfWork.Save();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Car Update(Car car)
        {
            try
            {
                Car ret = _unitOfWork.CarRepository.Update(car);
                _unitOfWork.Save();
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Car Remove(int id)
        {
            try
            {
                Car car = FindById(id);
                Car ret = _unitOfWork.CarRepository.Remove(car);
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
