using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.Mappers
{
    public class AccidentMapper
    {
        public static NesrecaDTO EntityToEntityDto(Nesreca accident)
        {
            NesrecaDTO dto = new NesrecaDTO();

            dto.Opis = accident.Opis;
            dto.Datum = accident.Datum;
            dto.AutoId = accident.Id;
            if (accident.Sleper != null) dto.SleperId = accident.Sleper.Id;
            dto.Status = accident.Status;

            return dto;
        }

        public static Nesreca EntityDTOToEntity(NesrecaDTO dto, Auto auto, Sleper sleper)
        {
            Nesreca nesreca = new Nesreca();

            nesreca.Opis = dto.Opis;
            nesreca.Datum = dto.Datum;
            nesreca.Auto = auto;
            nesreca.Sleper = sleper;
            nesreca.Status= dto.Status;

            return nesreca;
        }

    }
}
