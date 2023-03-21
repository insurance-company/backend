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
        private readonly IUserService _userService;
        public TowTruckController(ITowTruckService towTruckService, IUserService userService)
        {
            _towTruckService = towTruckService;
            _userService = userService;
        }

        [Authorize(Roles = "MANAGER")]
        [HttpGet("GetAvaliable")]
        public ActionResult<List<TowTruck>> GetAvaliable(DateTime startTime, double duration)
        {
            int managerId = int.Parse(User.FindFirst("id").Value.ToString());
            int branchId = _userService.FindManagerById(managerId).WorksInBranch.Id;
            return _towTruckService.GetAvailableTowTrucks(branchId, startTime, duration);
        }
    }
}
