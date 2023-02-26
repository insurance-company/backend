using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SignedPolicyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISignedPolicyService _signedPolicyService;
        public SignedPolicyController(IMapper mapper, ISignedPolicyService signedPolicyService)
        {
            _mapper = mapper;
            _signedPolicyService = signedPolicyService;
        }

        [HttpGet("getAllByAgentId/{agentId}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<PotpisanaPolisa>> GetAllByAgentId(int agentId, int pageNumber, int pageSize)
        {
            return _signedPolicyService.GetAllByAgentId(agentId, pageNumber, pageSize);
        }

        [HttpGet("getAllByBuyerId/{buyerId}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<PotpisanaPolisa>> GetAllByBuyerId(int buyerId, int pageNumber, int pageSize)
        {
            return _signedPolicyService.GetAllByBuyerId(buyerId, pageNumber, pageSize);
        }
    }
}
