using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Api.Mappers;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PolicyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISignedPolicyService _signedPolicyService;
        private readonly IAidPackageService _aidPackageService;
        private readonly ICarService _carService;
        public PolicyController(IMapper mapper, ISignedPolicyService signedPolicyService, IAidPackageService aidPackageService, ICarService carService)
        {
            _mapper = mapper;
            _signedPolicyService = signedPolicyService;
            _aidPackageService = aidPackageService;
            _carService = carService;
        }

        [Authorize(Roles = "AGENT")]
        [HttpGet("getAllByAgentId/{agentId}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<SignedPolicy>> GetAllByAgentId(int agentId, int pageNumber, int pageSize)
        {
            return _signedPolicyService.GetAllByAgentId(agentId, pageNumber, pageSize);
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpGet("getAllByBuyerId/{buyerId}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<SignedPolicy>> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize)
        {
            return _signedPolicyService.GetAllByBuyerId(buyerId, pageNumber, pageSize);
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpPost("buyPolicy")]
        public ActionResult<SignedPolicy> BuyPolicy(SignedPolicyDTO policy)
        {
               return _signedPolicyService.BuyPolicy(SignedPolicyMapper.EntityDTOToEntity(policy, _aidPackageService.FindById(policy.AidPackageId), null, _carService.FindById(policy.CarId)));
        }
    }
}
