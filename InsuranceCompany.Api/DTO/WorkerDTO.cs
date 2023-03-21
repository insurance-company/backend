using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.DTO
{
    public class WorkerDTO : UserDTO
    {
        public int BossId { get; set; }
        public int WorksInBranchId { get; set; }
    }
}
