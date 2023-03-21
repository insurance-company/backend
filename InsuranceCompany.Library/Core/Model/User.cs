using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class User : Entity
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string UniqueMasterCitizenNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public Gender Gender { get; private set; }

        protected User() { }

        protected User(string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender)
        {
            Email = email;
            Password = password;
            Role = role;
            FirstName = firstName;
            LastName = lastName;
            UniqueMasterCitizenNumber = uniqueMasterCitizenNumber;
            PhoneNumber = phoneNumber;
            Address = address;
            Gender = gender;
        }

        public static User Create(string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender)
        {
            return new User(email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender);
        }

        public void Register(string password, Model.Enum.Role role)
        {
            Password = password;
            Role = role.ToString();

        }

    }
}
