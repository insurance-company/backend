using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.Profiles
{
    public class CarMapperProfile : Profile
    {
        public CarMapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Accident, AccidentDTO>().ReverseMap();
        }

    }
}
