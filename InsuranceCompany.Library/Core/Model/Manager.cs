using InsuranceCompany.Library.Core.Model.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Manager : Worker
    {
        public Branch ManagesTheBranch { get; private set; }

        private Manager() { }

        private Manager(Branch managesTheBranch, Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, string address, Gender gender) : base(boss, worksInBranch, email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender)
        {
            ManagesTheBranch = managesTheBranch;
        }

        public static Manager Create(Branch managesTheBranch, Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, string address, Gender gender)
        {
            return new Manager(managesTheBranch, boss, worksInBranch, email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender);
        }
    }
}
