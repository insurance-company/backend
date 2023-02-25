using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NesrecaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly INesrecaService _nesrecaService;
        public NesrecaController(IMapper mapper, INesrecaService nesrecaService)
        {
            _mapper = mapper;
            _nesrecaService = nesrecaService;
        }
        [HttpGet("getAllByUserId/{id}")]
        public ActionResult<List<Nesreca>> GetAll(int id)
        {
            return _nesrecaService.GetAllByUserId(id);
        }

        [HttpGet("getAllUnvalidated")]
        public ActionResult<List<Nesreca>> GetAllUnvalidated()
        {
            return _nesrecaService.GetAllUnvalidated();
        }
    }
}
