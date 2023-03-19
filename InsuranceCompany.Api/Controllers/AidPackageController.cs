using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Api.Mappers;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AidPackageController : ControllerBase
    {
        private readonly IAidPackageService _aidPackageService;
        public AidPackageController(IAidPackageService aidPackageService)
        {
            _aidPackageService = aidPackageService;
        }
        [HttpGet("getAll/{pageNumber}/{pageSize}")]
        public ActionResult<Page<AidPackage>> GetAll(int pageNumber, int pageSize)
        {
            return _aidPackageService.GetAll(pageNumber, pageSize);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("Create")]
        public ActionResult Create(AidPackageDTO aidPackageDTO)
        {
            _aidPackageService.Create(AidPackageMapper.EntityDTOToEntity(aidPackageDTO));
            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("Update")]
        public ActionResult Update(AidPackageDTO aidPackageDTO)
        {
            _aidPackageService.Update(AidPackageMapper.EntityDTOToEntity(aidPackageDTO));
            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("Remove")]
        public ActionResult Delete(int aidPackageId)
        {
            _aidPackageService.Remove(aidPackageId);
            return Ok();
        }
    }
}
