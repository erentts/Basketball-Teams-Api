using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.DTOs;

namespace BasketballTeamsApi.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDto>();
            CreateMap<TeamDto, Team>();

            CreateMap<Team, TeamWithPlayersDto>();
            CreateMap<TeamWithPlayersDto, Team>();

            CreateMap<Player, PlayerDto>();
            CreateMap<PlayerDto, Player>();

            CreateMap<Player, PlayerWithTeamDto>();
            CreateMap<PlayerWithTeamDto, Player>();
        }
    }
}
