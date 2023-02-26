using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController
    {
        private readonly IMapper _mapper;
        private readonly ICarService _carService;
        public CarController(IMapper mapper, ICarService carService)
        {
            _mapper = mapper;
            _carService = carService;
        }

        [HttpGet("getAllByOwnerId/{id}")]
        public ActionResult<List<Auto>> GetAllByOwnerId(int id)
        {
            return _carService.FindAllByOwnerId(id);
        }
    }
}
