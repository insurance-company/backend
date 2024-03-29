﻿using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service
{
    public class PolicyService : IPolicyService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IEmailService _emailService;
        public PolicyService(IUnitOfWork unitOfWork, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _emailService = emailService;
        }

        public Policy FindById(int aidPackageId, int carId) 
        {
            return _unitOfWork.PolicyRepository.FindById(aidPackageId, carId);
        }
        public Page<Policy> GetAllByAgentId(int agentId, int pageNumber, int pageSize)
        {
            List<Policy> signedPolicies = _unitOfWork.PolicyRepository.GetAllByAgentId(agentId);
            Page<Policy> page = new Page<Policy>();
            page.TotalCount = signedPolicies.Count;
            page.Data = signedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Page<Policy> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize)
        {
            List<Policy> signedPolicies = _unitOfWork.PolicyRepository.GetAllByBuyerId(buyerId);
            Page<Policy> page = new Page<Policy>();
            page.TotalCount = signedPolicies.Count;
            page.Data = signedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public Policy BuyPolicy(Policy policy)
        {
            return _unitOfWork.PolicyRepository.Create(policy);
        }

        public Page<Policy> GetAllUnsigned(int pageNumber, int pageSize)
        {
            List<Policy> unsignedPolicies = _unitOfWork.PolicyRepository.GetAllUnsigned();
            Page<Policy> page = new Page<Policy>();
            page.TotalCount = unsignedPolicies.Count;
            page.Data = unsignedPolicies.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return page;
        }

        public void SignOrDecline(int aidPackageId, int carId, bool sign, int agentId)
        {
            try
            {
                Policy policy = _unitOfWork.PolicyRepository.FindById(aidPackageId, carId);
                string text = "";
                if (sign == true)
                {
                    policy.Sign(_unitOfWork.AgentRepository.FindById(agentId));
                    _unitOfWork.PolicyRepository.Update(policy);
                    text = "Postovanje, <br><br>Vaša polisa je potpisana! <br>Automobil: " + policy.Car.RegisterNumber + 
                        "<br>Paket pomoći: " + policy.AidPackage.Description + 
                        "<br>Agent: " + policy.Agent.FirstName + " " + policy.Agent.LastName + ", Br Licence: " + policy.Agent.LicenceNumber + 
                        "<br><br>Srdačan pozdrav," +
                        "<br>Agencija za osiguranje automobila TESLA.";
                }
                else
                {
                    //policy.Deleted = true;
                    _unitOfWork.PolicyRepository.Remove(policy);
                    text = "Postovanje, <br> <br>Vaša polisa je odbijena! <br>Automobil: " + policy.Car.RegisterNumber + 
                        "<br>Paket pomoći: " + policy.AidPackage.Description +
                        "<br><br>Srdačan pozdrav," +
                        "<br>Agencija za osiguranje automobila TESLA.";
                }

                _unitOfWork.Save();
                _emailService.SendEmail("STATUS POLISE", text, policy.Car.Owner.Email.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Policy> GetAllValidByCustomer(int customerId)
        {
            return _unitOfWork.PolicyRepository.GetAllValidByCustomer(customerId);
        }
    }
}