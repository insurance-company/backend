﻿using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Service.Core
{
    public interface ICarService
    {
        Auto FindById(int id);
        List<Auto> FindAllByOwnerId(int id);
    }
}
