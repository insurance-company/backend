using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service
{
    public class UserService : IUserService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Page<User> GetAllBuyers(int pageNumber, int pageSize)
        {
            List<User> users =  _unitOfWork.UserRepository.GetAllBuyers();
            Page<User> page = new Page<User>();
            page.TotalCount = users.Count;
            page.Data = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public User FindByEmail(string email)
        {
            return _unitOfWork.UserRepository.FindByEmail(email);
        }

        public User RegisterCustomer(User user)
        {
            user.Password = PasswordHasher.HashPassword(user.Password);
            user.Role = Model.Enum.Role.CUSTOMER.ToString();
            return _unitOfWork.UserRepository.Create(user);
        }

        public Manager RegisterManager(Manager manager)
        {
            manager.Password = PasswordHasher.HashPassword(manager.Password);
            manager.Role = Model.Enum.Role.MANAGER.ToString();
            return _unitOfWork.UserRepository.CreateManager(manager);
        }

        public User FindById(int id)
        {
            return _unitOfWork.UserRepository.FindById(id);
        }

        public Manager FindManagerById(int id)
        {
            return _unitOfWork.UserRepository.FindManagerById(id);
        }
    }
}
