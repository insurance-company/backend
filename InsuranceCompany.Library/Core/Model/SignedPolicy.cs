using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class SignedPolicy : Entity
    {
        public DateTime Date { get; set; }
        public AidPackage AidPackage { get; set; }
        [AllowNull]
        public Agent? Agent { get; set; }
        public Car Car { get; set; }

        private SignedPolicy() { }
        private SignedPolicy(DateTime dateOfSigning, AidPackage aidPackage, Agent? agent, Car car)
        {
            Date = dateOfSigning;
            AidPackage = aidPackage;
            Agent = agent;
            Car = car;
        }

        public static SignedPolicy Create(DateTime date, AidPackage aidPackage, Agent agent, Car car)
        {
            return new SignedPolicy(date, aidPackage, agent, car);
        }
    }
}
