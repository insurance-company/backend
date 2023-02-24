using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilijalaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFilijalaService _filijalaService;
        public FilijalaController(IMapper mapper, IFilijalaService filijalaService)
        {
            _mapper = mapper;
            _filijalaService = filijalaService;
        }
        [HttpGet]
        public ActionResult<List<Filijala>> GetAll()
        {
            return _filijalaService.GetAll();
        }
    }
}
