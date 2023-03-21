using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using InsuranceCompany.Library.Helpers.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PDFController : ControllerBase
    {
        private readonly IPDFExporterService _pdfService;
        public PDFController(IPDFExporterService pdfService)
        {
            _pdfService= pdfService;
        }

        [Authorize(Roles = "AGENT")]
        [HttpGet("getPolicyPDF")]
        public IActionResult GetPolicyPDF(int aidPackageId, int carId)
        {
            return _pdfService.GeneratePolicyPDF(aidPackageId, carId);
        }
    }
}
