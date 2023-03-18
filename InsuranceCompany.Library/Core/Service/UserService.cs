using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;
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
        public Page<User> GetAllCustomers(int pageNumber, int pageSize)
        {
            List<User> users =  _unitOfWork.UserRepository.GetAllCustomers();
            Page<User> page = new Page<User>();
            page.TotalCount = users.Count;
            page.Data = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public List<Worker> GetAllWorkers()
        {
            return _unitOfWork.UserRepository.GetAllWorkers();
        }

        public List<Agent> GetAllAgents()
        {
            return _unitOfWork.AgentRepository.GetAll();
        }

        public User FindByEmail(string email)
        {
            return _unitOfWork.UserRepository.FindByEmail(email);
        }

        public User RegisterCustomer(User user)
        {
            user.Register(PasswordHasher.HashPassword(user.Password), Role.CUSTOMER);
            return _unitOfWork.UserRepository.Create(user);
        }

        public Manager RegisterManager(Manager manager)
        {
            manager.Register(PasswordHasher.HashPassword(manager.Password), Role.MANAGER);
            //fali works in branch dodaj na frontu
            return _unitOfWork.ManagerRepository.Create(manager);
        }

        public Agent RegisterAgent(Agent agent)
        {
            agent.Register(PasswordHasher.HashPassword(agent.Password), Role.AGENT);
            return _unitOfWork.AgentRepository.Create(agent);
        }

        public User FindById(int id)
        {
            return _unitOfWork.UserRepository.FindById(id);
        }

        public Manager FindManagerById(int id)
        {
            return _unitOfWork.ManagerRepository.FindById(id);
        }
    }
}
