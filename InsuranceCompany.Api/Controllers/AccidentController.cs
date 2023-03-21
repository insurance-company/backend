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
        private readonly IPolicyService _policyService;
        private readonly ITowTruckService _towTruckService;
        private readonly IUserService _userService;
        public AccidentController(IMapper mapper, IAccidentService accidentService, IPolicyService policyService, ITowTruckService towTruckService, IUserService userService)
        {
            _mapper = mapper;
            _accidentService = accidentService;
            _policyService = policyService;
            _towTruckService = towTruckService;
            _userService = userService;
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
            Accident createdAccident = _accidentService.Create(AccidentMapper.EntityDTOToEntity(accident, _policyService.FindById(accident.PolicyAidPackageId, accident.PolicyCarId), null));
            return AccidentMapper.EntityToEntityDto(createdAccident);
        }

        [Authorize(Roles = "MANAGER")]
        [HttpPut("validate")]
        public ActionResult<AccidentDTO> ValidateAccident([FromBody] AccidentDTO dto)
        {
            int managerId = int.Parse(User.FindFirst("id").Value.ToString());
            Manager manager = _userService.FindManagerById(managerId);
            Accident accident = _accidentService.Validate(AccidentMapper.EntityDTOToEntity(dto, _policyService.FindById(dto.PolicyAidPackageId, dto.PolicyCarId), _towTruckService.FindById(dto.TowTruckId)), manager);
            return Ok(AccidentMapper.EntityToEntityDto(accident));
        }
    }
}
