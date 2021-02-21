using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.Core.Services;

namespace BasketballTeamsApi.Core.Services
{
    public interface IPlayerService:IService<Player>
    {
        Task<Player> GetWithTeamByIdAsync(int playerId);
    }
}
