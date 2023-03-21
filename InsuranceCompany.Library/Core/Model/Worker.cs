using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Worker : User
    {
        [AllowNull]
        public Worker? Boss { get; private set; }
        public Branch WorksInBranch { get; private set; }

        protected Worker() { }
        protected Worker(Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender) : base(email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender) 
        {
            Boss = boss;
            WorksInBranch = worksInBranch;
        }

    }
}
