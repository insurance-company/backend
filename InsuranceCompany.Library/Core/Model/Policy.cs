using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Policy
    {
        public int CarId { get; set; }
        public Car Car { get; private set; }
        public int AidPackageId { get; set; }
        public AidPackage AidPackage { get; private set; }
        public DateTime Date { get; private set; }
        [AllowNull]
        public Agent? Agent { get; private set; }

        public bool Deleted { get; set; }

        private Policy() { }
        private Policy(DateTime dateOfSigning, AidPackage aidPackage, Agent? agent, Car car)
        {
            AidPackageId = aidPackage.Id;
            CarId = car.Id;
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
