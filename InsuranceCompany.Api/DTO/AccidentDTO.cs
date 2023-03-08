using InsuranceCompany.Library.Core.Model.Enum;
using InsuranceCompany.Library.Core.Model;
using System.Diagnostics.CodeAnalysis;

namespace InsuranceCompany.Api.DTO
{
    public class AccidentDTO
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
        public int TowTruckId { get; set; }
        public AccidentStatus Status { get; set; }
    }
}
