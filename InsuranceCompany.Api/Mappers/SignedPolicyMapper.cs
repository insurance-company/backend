﻿using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.Mappers
{
    public class SignedPolicyMapper
    {
        public static SignedPolicyDTO EntityToEntityDto(SignedPolicy signedPolicy)
        {
            SignedPolicyDTO dto = new SignedPolicyDTO();

            dto.Date = signedPolicy.Date;
            dto.AidPackageId = signedPolicy.AidPackage.Id;
            dto.AgentId = signedPolicy.Agent.Id;
            dto.CarId = signedPolicy.Car.Id;

            return dto;
        }

        public static SignedPolicy EntityDTOToEntity(SignedPolicyDTO dto, AidPackage aidPackage,Agent agent, Car car)
        {
            SignedPolicy signedPolicy = SignedPolicy.Create(dto.Date, aidPackage, agent, car);

            return signedPolicy;
        }

    }
}
