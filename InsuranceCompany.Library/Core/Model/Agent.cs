using InsuranceCompany.Library.Core.Model.Enum;


namespace InsuranceCompany.Library.Core.Model
{
    public class Agent : Worker
    {
        public string LicenceNumber { get; private set; }

        private Agent() { }

        private Agent(string licenceNumber, Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender) : base(boss, worksInBranch, email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender)
        {
            LicenceNumber = licenceNumber;
        }

        public static Agent Create(string managesTheBranch, Worker boss, Branch worksInBranch, string email, string password, string role, string firstName, string lastName, string uniqueMasterCitizenNumber, string phoneNumber, Address address, Gender gender)
        {
            return new Agent(managesTheBranch, boss, worksInBranch, email, password, role, firstName, lastName, uniqueMasterCitizenNumber, phoneNumber, address, gender);
        }
    }
}
