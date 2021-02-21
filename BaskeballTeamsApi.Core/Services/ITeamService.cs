using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Entities;

namespace BasketballTeamsApi.Core.Services
{
    public interface ITeamService:IService<Team>
    {
        Task<Team> GetWithPlayersByIdAsync(int teamId);
    }
}
