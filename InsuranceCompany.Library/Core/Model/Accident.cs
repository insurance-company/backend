using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Accident : Entity
    {
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public Car Car { get; private set; }
        [AllowNull]
        public TowTruck? TowTruck { get; private set; }
        public DateTime TowingStartTime { get; private set; }
        public double TowingDuration { get; private set; }
        public AccidentStatus Status { get; private set; }

        private Accident() { }

        public Accident(string description, DateTime date, Car car, TowTruck? towTruck, DateTime towingStartTime, double towingDuration, AccidentStatus status)
        {
            Description = description;
            Date = date;
            Car = car;
            TowTruck = towTruck;
            TowingStartTime = towingStartTime;
            TowingDuration = towingDuration;
            Status = status;
        }

        public static Accident Create(string description, DateTime date, Car car, TowTruck? towTruck, DateTime towingStartTime, double towingDuration, AccidentStatus status)
        {
            return new Accident(description, date, car, towTruck, towingStartTime, towingDuration, status);
        }

        public void Validate(AccidentStatus status, TowTruck? towTruck, DateTime towingStartTime, double towingDuration)
        {
            this.Status = status;
            this.TowTruck = towTruck;
            this.TowingStartTime = towingStartTime;
            this.TowingDuration = towingDuration;
        }
    }
}
