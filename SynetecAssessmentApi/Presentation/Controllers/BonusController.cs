using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SynetecAssessmentApi.Application.Dtos;
using SynetecAssessmentApi.Application.Services;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class BonusController : ControllerBase
    {
        private readonly IBonusService _bonusService;
        private readonly IMapper _mapper;
        public BonusController(
            IBonusService bonusService,
            IMapper mapper
        )
        {
            _bonusService = bonusService;
            _mapper = mapper;
        }

        [HttpPost("getallbonuses")]
        public async Task<IActionResult> GetAllBonuses([FromBody] BonusRequestDTO bonusRequest)
        {
            var result = await _bonusService.GetAllBonuses(bonusRequest);
            return new ObjectResult(result);
        }

        [HttpPost("getbonusbyemployee")]
        public async Task<IActionResult> GetBonusById([Required] int employeeId, [FromBody] BonusRequestDTO bonusRequest)
        {
            var result = await _bonusService.GetBonusById(employeeId, bonusRequest);
            if (result != null)
            {
                return new OkObjectResult(result);
            } else
            {
                string badRequestMessage = "Employee is not found, please try again with another Employee ID.";
                return BadRequest(badRequestMessage);
            }
        }
    }
}
