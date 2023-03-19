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

        private AidPackage() {}

        private AidPackage(int id, int durationInMonths, double price, string description, double cover) : base(id)
        {
            DurationInMonths = durationInMonths;
            Price = price;
            Description = description;
            Cover = cover;
        }

        public static AidPackage Create(int id, int durationInMonths, double price, string description, double cover)
        {
            return new AidPackage(id, durationInMonths, price, description, cover);
        }
    }
}
