using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueMasterCitizenNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }

        public User() { }

        private User(string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, string address, Gender gender)
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

        public static User Create(string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, string address, Gender gender)
        {
            return new User(email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender);
        }

    }
}
