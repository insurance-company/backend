using InsuranceCompany.Library.Core.Model;

namespace InsuranceCompany.Api.DTO
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string RegisterNumber { get; set; }
        public int Years { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int OwnerId { get; set; }
    }
}
