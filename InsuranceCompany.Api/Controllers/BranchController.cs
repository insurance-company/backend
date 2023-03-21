using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Api.Mappers;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBranchService _branchService;
        private readonly IAgencyService _agencyService;
        public BranchController(IMapper mapper, IBranchService branchService, IAgencyService agencyService)
        {
            _mapper = mapper;
            _branchService = branchService;
            _agencyService = agencyService;
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

        [Authorize(Roles = "ADMIN")]
        [HttpPost("Create")]
        public ActionResult Create(BranchDTO dto)
        {
            _branchService.Create(BranchMapper.EntityDTOToEntity(dto, _agencyService.GetFirstOrDefault()));
            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("Update")]
        public ActionResult Update(BranchDTO branchDTO)
        {
            _branchService.Update(BranchMapper.EntityDTOToEntity(branchDTO, _agencyService.GetFirstOrDefault()));
            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("Remove")]
        public ActionResult Delete(int branchId)
        {
            _branchService.Remove(branchId);
            return Ok();
        }
    }
}
