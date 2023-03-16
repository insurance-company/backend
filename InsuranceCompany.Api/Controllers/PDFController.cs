using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using InsuranceCompany.Library.Helpers.Interfaces;
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
        [HttpGet("getPolicyPDF")]
        public IActionResult GetPolicyPDF(int id)
        {
            return _pdfService.GeneratePolicyPDF(id);
        }
    }
}
