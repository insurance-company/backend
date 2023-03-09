using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.Mappers
{
    public class AidPackageMapper
    {
        public static AidPackageDTO EntityToEntityDto(AidPackage package)
        {
            AidPackageDTO dto = new AidPackageDTO();

            dto.Id = package.Id;
            dto.DurationInMonths = package.DurationInMonths;
            dto.Price = package.Price;
            dto.Description = package.Description;
            dto.Cover = package.Cover;

            return dto;
        }

        public static AidPackage EntityDTOToEntity(AidPackageDTO dto)
        {
            return AidPackage.Create(dto.Id, dto.DurationInMonths, dto.Price, dto.Description, dto.Cover);
        }
    }
}
