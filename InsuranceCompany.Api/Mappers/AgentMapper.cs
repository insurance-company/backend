using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model.Enum;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Migrations;

namespace InsuranceCompany.Api.Mappers
{
    public class AgentMapper
    {
        public static AgentDTO EntityToEntityDto(Agent agent)
        {
            AgentDTO dto = new AgentDTO();

            dto.Email = agent.Email;
            dto.Password = "";
            dto.Role = Enum.Parse<Role>(agent.Role);
            dto.FirstName = agent.FirstName;
            dto.LastName = agent.LastName;
            dto.UniqueMasterCitizenNumber = agent.UniqueMasterCitizenNumber;
            dto.PhoneNumber = agent.PhoneNumber;
            dto.Address = agent.Address;
            dto.Gender = agent.Gender;
            if (agent.Boss != null) dto.BossId = agent.Boss.Id;
            dto.LicenceNumber = agent.LicenceNumber;

            return dto;
        }

        public static Agent EntityDTOToEntity(AgentDTO dto, Worker boss, Branch worksInBranch)
        {
            Agent agent = new Agent();

            agent.Email = dto.Email;
            agent.Password = dto.Password;
            agent.Role = dto.Role.ToString();
            agent.FirstName = dto.FirstName;
            agent.LastName = dto.LastName;
            agent.UniqueMasterCitizenNumber = dto.UniqueMasterCitizenNumber;
            agent.PhoneNumber = dto.PhoneNumber;
            agent.Address = dto.Address;
            agent.Gender = dto.Gender;
            agent.Boss = boss;
            agent.WorksInBranch = worksInBranch;
            agent.LicenceNumber = dto.LicenceNumber;

            return agent;
        }
    }
}
