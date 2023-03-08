using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Api.Mappers;
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
        private readonly ICarService _carService;
        public AccidentController(IMapper mapper, IAccidentService nesrecaService, ICarService carService)
        {
            _mapper = mapper;
            _nesrecaService = nesrecaService;
            _carService = carService;
        }
        [HttpGet("getAllByUserId/{id}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Accident>> GetAll(int id, int pageNumber, int pageSize)
        {
            return _nesrecaService.GetAllByUserId(id, pageNumber, pageSize);
        }

        [HttpGet("getAllUnvalidated/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Accident>> GetAllUnvalidated(int pageNumber, int pageSize)
        {
            return _nesrecaService.GetAllUnvalidated(pageNumber, pageSize);
        }

        [HttpPost("createAccident")]
        public ActionResult<AccidentDTO> Create([FromBody] AccidentDTO accident)
        {
            Accident createdAccident = _nesrecaService.Create(AccidentMapper.EntityDTOToEntity(accident, _carService.FindById(accident.CarId), null));
            return AccidentMapper.EntityToEntityDto(createdAccident);
        }
    }
}
