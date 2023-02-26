using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public ActionResult Authenticate([FromBody] LoginDTO userObj)
        {
            if (userObj == null) return BadRequest();

            var user = _userService.FindByEmail(userObj.Email);
            if (user == null) return NotFound("User not found");

            if (!PasswordHasher.VerifyPassword(userObj.Password, user.Password)) return BadRequest("Password is incorrect!");

            return Ok(new
            {
                Token = JwtToken.CreateJwtToken(user),
                Message = "Login Success"
            });
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] UserDTO userObjDTO)
        {
            
            if (userObjDTO == null) return BadRequest();
            if (_userService.FindByEmail(userObjDTO.Email) != null) return BadRequest("Email already in use");
            _userService.Register(_mapper.Map<User>(userObjDTO));
            return Ok();
        }


        [Authorize(Roles = "Menadzer, Agent")]
        [HttpGet("getAllBuyers/{pageNumber}/{pageSize}")]
        public ActionResult<Page<User>> GetAllBuyers(int pageNumber, int pageSize)
        {
           return _userService.GetAllBuyers(pageNumber, pageSize);
        }

        [HttpGet("getById/{id}")]
        public ActionResult<User> FindById(int id)
        {
            return _userService.FindById(id);
        }
    }
}
