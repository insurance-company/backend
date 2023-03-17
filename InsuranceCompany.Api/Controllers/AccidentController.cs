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
    public class AccidentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAccidentService _accidentService;
        private readonly ICarService _carService;
        private readonly ITowTruckService _towTruckService;
        public AccidentController(IMapper mapper, IAccidentService accidentService, ICarService carService, ITowTruckService towTruckService)
        {
            _mapper = mapper;
            _accidentService = accidentService;
            _carService = carService;
            _towTruckService = towTruckService;
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpGet("getAllByUserId/{id}/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Accident>> GetAll(int id, int pageNumber, int pageSize)
        {
            return _accidentService.GetAllByUserId(id, pageNumber, pageSize);
        }

        [Authorize(Roles = "MANAGER")]
        [HttpGet("getAllUnvalidated/{pageNumber}/{pageSize}")]
        public ActionResult<Page<Accident>> GetAllUnvalidated(int pageNumber, int pageSize)
        {
            return _accidentService.GetAllUnvalidated(pageNumber, pageSize);
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpPost("create")]
        public ActionResult<AccidentDTO> Create([FromBody] AccidentDTO accident)
        {
            Accident createdAccident = _accidentService.Create(AccidentMapper.EntityDTOToEntity(accident, _carService.FindById(accident.CarId), null));
            return AccidentMapper.EntityToEntityDto(createdAccident);
        }

        [Authorize(Roles = "MANAGER")]
        [HttpPut("validate")]
        public ActionResult<AccidentDTO> ValidateAccident([FromBody] AccidentDTO dto)
        {
            Accident accident = _accidentService.Update(AccidentMapper.EntityDTOToEntity(dto, _carService.FindById(dto.CarId), _towTruckService.FindById(dto.TowTruckId)));
            return Ok(AccidentMapper.EntityToEntityDto(accident));
        }
    }
}
