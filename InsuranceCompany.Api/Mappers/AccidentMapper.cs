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

            dto.Description = accident.Description;
            dto.Date = accident.Date;
            dto.CarId = accident.Id;
            if (accident.TowTruck != null) dto.TowTruckId = accident.TowTruck.Id;
            dto.Status = accident.Status;

            return dto;
        }

        public static Accident EntityDTOToEntity(AccidentDTO dto, Car car, TowTruck towTruck)
        {
            Accident nesreca = new Accident();

            nesreca.Description = dto.Description;
            nesreca.Date = dto.Date;
            nesreca.Car = car;
            nesreca.TowTruck = towTruck;
            nesreca.Status= dto.Status;

            return nesreca;
        }

    }
}
