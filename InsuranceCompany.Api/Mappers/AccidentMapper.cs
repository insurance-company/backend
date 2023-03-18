using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.Mappers
{
    public class AccidentMapper
    {
        public static AccidentDTO EntityToEntityDto(Accident accident)
        {
            AccidentDTO dto = new AccidentDTO();

            dto.Id = accident.Id;
            dto.Description = accident.Description;
            dto.Date = accident.Date;
            dto.CarId = accident.Id;
            if (accident.TowTruck != null) dto.TowTruckId = accident.TowTruck.Id;
            dto.TowingStartTime = accident.TowingStartTime;
            dto.TowingDuration = accident.TowingDuration;
            dto.Status = accident.Status;

            return dto;
        }

        public static Accident EntityDTOToEntity(AccidentDTO dto, Car car, TowTruck towTruck)
        {
            Accident accident = Accident.Create(dto.Description, dto.Date, car, towTruck, dto.TowingStartTime, dto.TowingDuration, dto.Status);
            accident.Id = dto.Id;
            return accident;
        }

    }
}
