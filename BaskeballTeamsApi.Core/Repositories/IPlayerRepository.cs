using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Entities;

namespace BasketballTeamsApi.Core.Repositories
{
    public interface IPlayerRepository:IRepository<Player>
    {
        Task<Player> GetWithTeamByIdAsync(int playerId);
    }
}
