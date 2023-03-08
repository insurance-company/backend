using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBranchOfficeService _filijalaService;
        public BranchController(IMapper mapper, IBranchOfficeService filijalaService)
        {
            _mapper = mapper;
            _filijalaService = filijalaService;
        }
        [HttpGet("getAll/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Branch>> GetAll(int pageNumber, int pageSize)
        {
            return _filijalaService.GetAll(pageNumber, pageSize);
        }
    }
}
