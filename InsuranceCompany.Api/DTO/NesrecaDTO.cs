using InsuranceCompany.Library.Core.Model.Enum;
using InsuranceCompany.Library.Core.Model;
using System.Diagnostics.CodeAnalysis;

namespace InsuranceCompany.Api.DTO
{
    public class NesrecaDTO
    {
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public int AutoId { get; set; }
        public int SleperId { get; set; }
        public StatusNesrece Status { get; set; }
    }
}
