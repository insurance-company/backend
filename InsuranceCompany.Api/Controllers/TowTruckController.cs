using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TowTruckController : ControllerBase
    {
        private readonly ITowTruckService _towTruckService;
        public TowTruckController(ITowTruckService towTruckService)
        {
            _towTruckService = towTruckService;
        }


        [HttpGet("GetAvaliable")]
        public ActionResult<List<TowTruck>> GetAvaliable(DateTime startTime, double duration)
        {
            return _towTruckService.GetAvailableTowTrucks(1, startTime, duration);
        }
    }
}
