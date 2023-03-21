using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.Mappers
{
    public class PolicyMapper
    {
        public static PolicyDTO EntityToEntityDto(Policy signedPolicy)
        {
            PolicyDTO dto = new PolicyDTO();

            dto.Date = signedPolicy.Date;
            dto.AidPackageId = signedPolicy.AidPackage.Id;
            dto.AgentId = signedPolicy.Agent.Id;
            dto.CarId = signedPolicy.Car.Id;

            return dto;
        }

        public static Policy EntityDTOToEntity(PolicyDTO dto, AidPackage aidPackage,Agent agent, Car car)
        {
            Policy signedPolicy = Policy.Create(dto.Date, aidPackage, agent, car);

            return signedPolicy;
        }

    }
}
