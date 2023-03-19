using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Car : Entity
    {
        public string RegisterNumber { get; private set; }
        public int Years { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public User Owner {get; private set; }

        private Car() { }

        private Car(string registerNumber, int years, string model, string brand, User owner)
        {
            RegisterNumber = registerNumber;
            Years = years;
            Model = model;
            Brand = brand;
            Owner = owner;
        }

        public static Car Create(string registerNumber, int years, string model, string brand, User owner)
        {
            return new Car(registerNumber, years, model, brand, owner);
        }
    }
}
