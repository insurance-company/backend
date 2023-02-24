using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using InsuranceCompany.Library.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly InsuranceCompanyDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UserController(InsuranceCompanyDbContext context, IMapper mapper, IUserService userService)
        {
            _context = context;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginDTO userObj)
        {
            if (userObj == null) return BadRequest();

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == userObj.Email);
            if (user == null) return NotFound("User not found");

            if (!PasswordHasher.VerifyPassword(userObj.Password, user.Password)) return BadRequest("Password is incorrect!");

            return Ok(new
            {
                Token = CreateJwtToken(user),
                Message = "Login Success"
            });
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] UserDTO userObjDTO)
        {
            
            if (userObjDTO == null) return BadRequest();
            //CheckEmail
            if (CheckEmailExist(userObjDTO.Email)) return BadRequest("Email already in use");
            var userObj = _mapper.Map<User>(userObjDTO);
            userObj.Password = PasswordHasher.HashPassword(userObj.Password);
            userObj.Role = "User";
            _context.Users.AddAsync(userObj);
            _context.SaveChanges();

            return Ok();
        }

        private bool CheckEmailExist(string email)
        {
            return _context.Users.Any(x => x.Email == email);
        }

        private string CreateJwtToken(User user)
        {
            var JwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("veryverysecret.....");
            var identity = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.Name, $"{user.Ime} {user.Prezime}")
            });

            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };
            var token = JwtTokenHandler.CreateToken(tokenDescriptor);
            return JwtTokenHandler.WriteToken(token);
        }

        [Authorize]
        [HttpGet]
        public ActionResult<List<User>> GetAllBuyers()
        {
           return _userService.GetAllBuyers();
        }
    }
}
