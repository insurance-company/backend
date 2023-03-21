using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Policy : Entity
    {
        public DateTime Date { get; private set; }
        public AidPackage AidPackage { get; private set; }
        [AllowNull]
        public Agent? Agent { get; private set; }
        public Car Car { get; private set; }

        private Policy() { }
        private Policy(DateTime dateOfSigning, AidPackage aidPackage, Agent? agent, Car car)
        {
            Date = dateOfSigning;
            AidPackage = aidPackage;
            Agent = agent;
            Car = car;
        }

        public static Policy Create(DateTime date, AidPackage aidPackage, Agent agent, Car car)
        {
            return new Policy(date, aidPackage, agent, car);
        }

        public void Sign(Agent agent)
        {
            Agent = agent;
            Date = DateTime.Now;
        }
    }
}
