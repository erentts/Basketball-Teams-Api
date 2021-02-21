using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.Core.Services;
using BasketballTeamsApi.DTOs;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace BasketballTeamsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teams = await _teamService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<TeamDto>>(teams));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var team = await _teamService.GetByIdAsync(id);
            return Ok(_mapper.Map<TeamDto>(team));
        }

        [HttpGet("{id}/players")]
        public async Task<IActionResult> GetWithPlayersById(int id)
        {
            var team = await _teamService.GetWithPlayersByIdAsync(id);
            return Ok(_mapper.Map<TeamWithPlayersDto>(team));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TeamDto teamDto)
        {
            var team = await _teamService.AddAsync(_mapper.Map<Team>(teamDto));
            return Ok(_mapper.Map<TeamDto>(team));
        }

        [HttpPut]
        public IActionResult Update(TeamDto teamDto)
        {
            var team = _teamService.Update(_mapper.Map<Team>(teamDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var team = _teamService.GetByIdAsync(id).Result;
            _teamService.Remove(team);
            return NoContent();
        }

        
    }
}
