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
            dto.ManagesTheBranchId = manager.ManagesTheBranch.Id;

            return dto;
        }

        public static Manager EntityDTOToEntity(ManagerDTO dto, Worker boss, Branch branch)
        {
            Manager manager = new Manager();

            manager.Email = dto.Email;
            manager.Password = dto.Password;
            manager.Role = dto.Role.ToString();
            manager.FirstName= dto.FirstName;
            manager.LastName = dto.LastName;
            manager.UniqueMasterCitizenNumber= dto.UniqueMasterCitizenNumber;
            manager.PhoneNumber = dto.PhoneNumber;
            manager.Address = dto.Address;
            manager.Gender = dto.Gender;
            manager.Boss = boss;
            manager.ManagesTheBranch = branch;

            return manager;
        }
    }
}
