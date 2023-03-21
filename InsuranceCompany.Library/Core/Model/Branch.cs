using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Branch : Entity
    {
        public Agency Agency { get; private set; }
        public Address Address { get; private set; }
        private Branch() { }
        private Branch(Agency agency, Address address)
        {
            Agency = agency;
            Address = address;
        }
        public static Branch Create(Agency agency, Address address)
        {
            return new Branch(agency, address);
        }

    }
}
