using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Api.Mappers;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IBranchService _branchService;
        public AuthController(IMapper mapper, IUserService userService, IBranchService branchService)
        {
            _mapper = mapper;
            _userService = userService;
            _branchService = branchService;
        }

        [HttpPost("authenticate")]
        public ActionResult Authenticate([FromBody] LoginDTO userObj)
        {
            if (userObj == null) return BadRequest();

            var user = _userService.FindByEmail(userObj.Email);
            if (user == null) return NotFound("Nepostojeci korisnik");

            if (!PasswordHasher.VerifyPassword(userObj.Password, user.Password)) return BadRequest("Netacna lozinka!");

            return Ok(new
            {
                Token = JwtToken.CreateJwtToken(user),
                Message = "Uspesna prijava!"
            });
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] UserDTO userObjDTO)
        {

            if (userObjDTO == null) return BadRequest();
            if (_userService.FindByEmail(userObjDTO.Email) != null) return BadRequest("Email je vec iskoriscen");
            _userService.RegisterCustomer(_mapper.Map<User>(userObjDTO));
            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("registerManager")]
        public IActionResult RegisterManager([FromBody] ManagerDTO managerDTO)
        {

            if (managerDTO == null) return BadRequest();
            if (_userService.FindByEmail(managerDTO.Email) != null) return BadRequest("Email je vec iskoriscen");
            _userService.RegisterManager(ManagerMapper.EntityDTOToEntity(managerDTO, _userService.FindManagerById(managerDTO.BossId), _branchService.FindById(managerDTO.ManagesTheBranchId)));
            return Ok();
        }


        [Authorize(Roles = "MANAGER")]
        [HttpPost("registerAgent")]
        public IActionResult RegisterAgent([FromBody] AgentDTO agentDTO)
        {

            if (agentDTO == null) return BadRequest();
            if (_userService.FindByEmail(agentDTO.Email) != null) return BadRequest("Email je vec iskoriscen");
            int managerId = int.Parse(User.FindFirst("id").Value.ToString());
            _userService.RegisterAgent(AgentMapper.EntityDTOToEntity(agentDTO, _userService.FindManagerById(agentDTO.BossId), _branchService.FindById(_userService.FindManagerById(managerId).ManagesTheBranch.Id)));
            return Ok();
        }
    }
}
