using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }

    }
}
