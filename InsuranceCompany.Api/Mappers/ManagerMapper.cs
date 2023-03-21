using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.Mappers
{
    public class ManagerMapper
    {
        public static ManagerDTO EntityToEntityDto(Manager manager)
        {
            ManagerDTO dto = new ManagerDTO();

            dto.Email = manager.Email;
            dto.Password = "";
            dto.Role = Enum.Parse<Role>(manager.Role);
            dto.FirstName = manager.FirstName;
            dto.LastName = manager.LastName;
            dto.UniqueMasterCitizenNumber = manager.UniqueMasterCitizenNumber;
            dto.PhoneNumber = manager.PhoneNumber;
            dto.Address = manager.Address;
            dto.Gender = manager.Gender;
            if (manager.Boss != null)   dto.BossId = manager.Boss.Id;
            dto.WorksInBranchId = manager.WorksInBranch.Id;

            return dto;
        }

        public static Manager EntityDTOToEntity(ManagerDTO dto, Worker boss, Branch branch)
        {
            Manager manager = Manager.Create(dto.NumberOfValidatedAccidents, boss, branch, dto.Email, dto.Password, dto.Role.ToString(), dto.FirstName, dto.LastName, dto.UniqueMasterCitizenNumber, dto.PhoneNumber, dto.Address, dto.Gender);
            return manager;
        }
    }
}
