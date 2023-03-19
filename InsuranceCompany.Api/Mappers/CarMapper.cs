using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsuranceCompany.Api.Mappers
{
    public class CarMapper
    {
        public static CarDTO EntityToEntityDto(Car car)
        {
            CarDTO dto = new CarDTO();

            dto.Id = car.Id;
            dto.RegisterNumber = car.RegisterNumber;
            dto.Brand = car.Brand;
            dto.Model = car.Model;
            dto.Years = car.Years;
            dto.OwnerId = car.Owner.Id;

            return dto;
        }

        public static Car EntityDTOToEntity(CarDTO dto, User owner)
        {
            Car car = Car.Create(dto.RegisterNumber, dto.Years, dto.Model, dto.Brand, owner);
            car.Id = dto.Id;
            return car;
        }
    }
}
