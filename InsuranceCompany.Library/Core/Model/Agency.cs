using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Agency : Entity
    {
        [StringLength(13)]
        public string PIB { get; private set; }
        public string Name { get; private set; }

    }
}
