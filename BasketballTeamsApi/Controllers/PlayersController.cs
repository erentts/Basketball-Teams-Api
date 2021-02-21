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

namespace BasketballTeamsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IMapper _mapper;

        public PlayersController(IPlayerService playerService, IMapper mapper)
        {
            _playerService = playerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var players = await _playerService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<PlayerDto>>(players));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var player = await _playerService.GetByIdAsync(id);
            return Ok(_mapper.Map<PlayerDto>(player));
        }

        [HttpGet("{id}/team")]
        public async Task<IActionResult> GetWithTeamById(int id)
        {
            var player = await _playerService.GetWithTeamByIdAsync(id);
            return Ok(_mapper.Map<PlayerWithTeamDto>(player));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PlayerDto playerDto)
        {
            var player = await _playerService.AddAsync(_mapper.Map<Player>(playerDto));
            return Ok(_mapper.Map<PlayerDto>(player));
        }

        [HttpPut]
        public IActionResult Update(PlayerDto playerDto)
        {
            var player = _playerService.Update(_mapper.Map<Player>(playerDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var player = _playerService.GetByIdAsync(id).Result;
            _playerService.Remove(player);
            return NoContent();
        }
    }
}
