﻿using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueMasterCitizenNumber { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }
    }
}
