using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.Mappers
{
    public class BranchMapper
    {
        public static BranchDTO EntityToEntityDto(Branch branch)
        {
            BranchDTO dto = new BranchDTO();

            dto.Id = branch.Id;
            dto.AgencyId = branch.Agency.Id;
            dto.Address = branch.Address;

            return dto;
        }

        public static Branch EntityDTOToEntity(BranchDTO dto, Agency agency)
        {
            Branch branch = Branch.Create(agency, dto.Address);
            branch.Id = dto.Id;
            return branch;
        }
    }
}
