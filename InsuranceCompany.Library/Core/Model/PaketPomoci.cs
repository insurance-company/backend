using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class PaketPomoci : Entity
    {
        public int TrajanjeUMesecima { get; set; }
        public double Cena { get; set; }
        public string Tip { get; set; }
        public double Pokrice { get; set; }

    }
}
