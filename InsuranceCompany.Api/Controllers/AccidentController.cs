using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccidentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAccidentService _nesrecaService;
        public AccidentController(IMapper mapper, IAccidentService nesrecaService)
        {
            _mapper = mapper;
            _nesrecaService = nesrecaService;
        }
        [HttpGet("getAllByUserId/{id}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Nesreca>> GetAll(int id, int pageNumber, int pageSize)
        {
            return _nesrecaService.GetAllByUserId(id, pageNumber, pageSize);
        }

        [HttpGet("getAllUnvalidated/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Nesreca>> GetAllUnvalidated(int pageNumber, int pageSize)
        {
            return _nesrecaService.GetAllUnvalidated(pageNumber, pageSize);
        }
    }
}
