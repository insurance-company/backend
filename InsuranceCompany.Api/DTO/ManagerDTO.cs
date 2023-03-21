using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.DTO
{
    public class ManagerDTO : WorkerDTO
    {
        public int NumberOfValidatedAccidents { get; set; }
    }
}
