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
        public int NumberOfValidatedAccidents { get; private set; }

        private Manager() { }

        private Manager(int numberOfValidatedAccidents, Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender) : base(boss, worksInBranch, email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender)
        {
            NumberOfValidatedAccidents = numberOfValidatedAccidents;
        }

        public static Manager Create(int numberOfValidatedAccidents, Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender)
        {
            return new Manager(numberOfValidatedAccidents, boss, worksInBranch, email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender);
        }

        public void ValidatedAccident()
        {
            NumberOfValidatedAccidents++;
        }
    }
}
