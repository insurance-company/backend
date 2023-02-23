using InsuranceCompany.Library.Core.Model.Enum;

namespace InsuranceCompany.Api.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public Pol Pol { get; set; }
    }
}
