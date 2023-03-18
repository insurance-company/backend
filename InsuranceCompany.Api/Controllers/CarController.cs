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
    public class CarController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICarService _carService;
        private readonly IUserService _userService;
        public CarController(IMapper mapper, ICarService carService, IUserService userService)
        {
            _mapper = mapper;
            _carService = carService;
            _userService = userService;
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpGet("getAllByOwnerId/{id}")]
        public ActionResult<List<Car>> GetAllByOwnerId(int id)
        {
            return _carService.FindAllByOwnerId(id);
        }


        [Authorize(Roles = "CUSTOMER")]
        [HttpPost("Create")]
        public ActionResult Create(CarDTO carDTO)
        {
            int customerId = int.Parse(User.FindFirst("id").Value.ToString());
            _carService.Create(CarMapper.EntityDTOToEntity(carDTO, _userService.FindById(customerId)));
            return Ok();
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpPut("Update")]
        public ActionResult Update([FromBody]CarDTO carDTO)
        {
            int customerId = int.Parse(User.FindFirst("id").Value.ToString());
            _carService.Update(CarMapper.EntityDTOToEntity(carDTO, _userService.FindById(customerId)));
            return Ok();
        }

        [Authorize(Roles = "CUSTOMER")]
        [HttpDelete("Remove")]
        public ActionResult Delete(int carId)
        {
            _carService.Remove(carId);
            return Ok();
        }
    }
}
