using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamsApi.DTOs
{
    public class PlayerWithTeamDto:PlayerDto
    {
        public TeamDto Team { get; set; }
    }
}
