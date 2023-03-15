using AutoMapper;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Service.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceCompany.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatisticsController
    {
        private readonly IStatisticsService _statService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statService = statisticsService;
        }

        [Authorize(Roles = "MANAGER")]
        [HttpGet("GetNumberOfAgentSignedPoliciesPerMonth")]
        public ActionResult<List<int>> GetNumberOfAgentSignedPoliciesPerMonth(int agentId, int year)
        {
            return _statService.GetNumberOfAgentSignedPoliciesPerMonth(agentId, year);
        }

        [Authorize(Roles = "MANAGER")]
        [HttpGet("GetNumberOfAccidentsPerMonth")]
        public ActionResult<List<int>> GetNumberOfAccidentsPerMonth(int year)
        {
            return _statService.GetNumberOfAccidentsPerMonth(year);
        }
    }
}
