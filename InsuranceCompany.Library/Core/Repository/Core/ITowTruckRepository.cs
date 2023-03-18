﻿using InsuranceCompany.Library.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface ITowTruckRepository
    {
        TowTruck? FindById(int id);
        List<TowTruck> GetAllByTowingServiceId(int id);
    }
}
