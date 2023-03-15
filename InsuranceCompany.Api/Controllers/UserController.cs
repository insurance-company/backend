using AutoMapper;
using InsuranceCompany.Api.DTO;
using InsuranceCompany.Api.Mappers;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        [Authorize(Roles = "MANAGER, AGENT")]
        [HttpGet("getAllBuyers/{pageNumber}/{pageSize}")]
        public ActionResult<Page<User>> GetAllBuyers(int pageNumber, int pageSize)
        {
           return _userService.GetAllBuyers(pageNumber, pageSize);
        }

        [Authorize(Roles = "MANAGER, AGENT, CUSTOMER, ADMIN")]
        [HttpGet("getById/{id}")]
        public ActionResult<UserDTO> FindById(int id)
        {
            User user = _userService.FindById(id);
            return UserMapper.EntityToEntityDto(user);
        }

        [HttpGet("getAllWorkers")]
        public ActionResult<List<Worker>> GetAllWorkers()
        {
            return Ok(_userService.GetAllWorkers());
        }

        [HttpGet("getAllAgents")]
        public ActionResult<List<Agent>> GetAllAgents()
        {
            return Ok(_userService.GetAllAgents());
        }
    }
}
