﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class Polisa : Entity
    {
        public DateTime Datum { get; set; }
        public PaketPomoci PaketPomoci { get; set; }
    }
}