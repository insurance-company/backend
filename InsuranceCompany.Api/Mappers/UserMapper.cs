using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.Mappers
{
    public class UserMapper
    {
        public static UserDTO EntityToEntityDto(User user)
        {
            UserDTO dto = new UserDTO();

            dto.Email = user.Email;
            dto.Password = "";
            dto.Role = user.Role;
            dto.FirstName = user.FirstName; 
            dto.LastName = user.LastName;
            dto.UniqueMasterCitizenNumber = user.UniqueMasterCitizenNumber;
            dto.PhoneNumber= user.PhoneNumber;
            dto.Address = user.Address;
            dto.Gender = user.Gender;

            return dto;
        }

        public static User EntityDTOToEntity(UserDTO dto)
        {
            User user = User.Create(dto.Email, dto.Password, dto.Role, dto.FirstName, dto.LastName, dto.UniqueMasterCitizenNumber, dto.PhoneNumber, dto.Address, dto.Gender);

            return user;
        }
    }
}
