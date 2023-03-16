using InsuranceCompany.Library.Core.Model.Enum;
using InsuranceCompany.Library.Core.Model;
using System.Diagnostics.CodeAnalysis;

namespace InsuranceCompany.Api.DTO
{
    public class SignedPolicyDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AidPackageId { get; set; }
        public int AgentId { get; set; }
        public int CarId { get; set; }
    }
}
