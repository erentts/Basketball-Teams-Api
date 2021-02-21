using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamsApi.DTOs
{
    public class TeamWithPlayersDto:TeamDto
    {
        public ICollection<PlayerDto> Players { get; set; }
    }
}
