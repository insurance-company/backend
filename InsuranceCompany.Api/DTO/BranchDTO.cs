using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.DTO
{
    public class BranchDTO
    {
        public int Id { get; set; }
        public int AgencyId { get; set; }
        public Address Address { get; set; }
    }
}
