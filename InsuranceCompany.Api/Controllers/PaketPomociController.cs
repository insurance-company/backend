using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PaketPomociController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPaketPomociService _paketPomociService;
        public PaketPomociController(IMapper mapper, IPaketPomociService paketPomociService)
        {
            _mapper = mapper;
            _paketPomociService = paketPomociService;
        }
        [HttpGet]
        public ActionResult<List<PaketPomoci>> GetAll()
        {
            return _paketPomociService.GetAll();
        }
    }
}
