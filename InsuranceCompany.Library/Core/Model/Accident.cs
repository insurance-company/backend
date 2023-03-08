using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Accident : Entity
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        [AllowNull]
        public TowTruck? TowTruck { get; set; }
        public AccidentStatus Status { get; set; }
    }
}
