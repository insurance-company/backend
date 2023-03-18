using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyService _agencyService;
   
        public AgencyController(IAgencyService agencyService)
        {
            _agencyService = agencyService;
        }

        [HttpGet]
        public ActionResult<Agency> GetFirstOrDefault()
        {
            return _agencyService.GetFirstOrDefault();
        }
    }
}
