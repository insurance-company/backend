using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class AidPackage : Entity
    {
        public int DurationInMonths { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public double Cover { get; private set; }

        public AidPackage() {}

        private AidPackage(int durationInMonths, double price, string description, double cover)
        {
            DurationInMonths = durationInMonths;
            Price = price;
            Description = description;
            Cover = cover;
        }

        public static AidPackage Create(int durationInMonths, double price, string description, double cover)
        {
            return new AidPackage(durationInMonths, price, description, cover);
        }
    }
}
