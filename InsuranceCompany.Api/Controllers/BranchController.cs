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
        private readonly IBranchService _branchService;
        public BranchController(IMapper mapper, IBranchService branchService)
        {
            _mapper = mapper;
            _branchService = branchService;
        }
        [HttpGet("getAll/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Branch>> GetAll(int pageNumber, int pageSize)
        {
            return _branchService.GetAll(pageNumber, pageSize);
        }

        [HttpGet("getAllWithoutPagination")]
        public ActionResult<List<Branch>> GetAllWithoutPagination(int pageNumber, int pageSize)
        {
            return _branchService.GetAllWithoutPagination();
        }
    }
}
