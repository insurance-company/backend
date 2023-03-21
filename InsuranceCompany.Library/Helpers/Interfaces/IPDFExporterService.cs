using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Helpers.Interfaces
{
    public interface IPDFExporterService
    {
        FileContentResult GeneratePolicyPDF(int aidPackageId, int carId);
    }
}
