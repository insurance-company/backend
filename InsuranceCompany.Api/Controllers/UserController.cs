using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceCompany.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly InsuranceCompanyDbContext _context;
        private readonly IMapper _mapper;
        public UserController(InsuranceCompanyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if (userObj == null) return BadRequest();

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == userObj.Email && x.Password == userObj.Password);
            if (user == null) return NotFound("User not found");

            return Ok("Login Success");
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDTO userObjDTO)
        {
            
            if (userObjDTO == null) return BadRequest();

            var userObj = _mapper.Map<User>(userObjDTO);

            await _context.Users.AddAsync(userObj);
            await _context.SaveChangesAsync();

            return Ok("User Registered");
        }
    }
}
