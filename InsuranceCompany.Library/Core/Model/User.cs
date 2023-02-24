﻿using InsuranceCompany.Library.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Model
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public Pol Pol { get; set; }


    }
}
