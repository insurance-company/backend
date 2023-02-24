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
        public List<User> GetAllBuyers()
        {
            return _unitOfWork.UserRepository.GetAllBuyers();
        }

        public User FindByEmail(string email)
        {
            return _unitOfWork.UserRepository.FindByEmail(email);
        }

        public User Register(User user)
        {
            user.Password = PasswordHasher.HashPassword(user.Password);
            user.Role = "User";
            return _unitOfWork.UserRepository.Create(user);
        }

        public User FindById(int id)
        {
            return _unitOfWork.UserRepository.FindById(id);
        }
    }
}
