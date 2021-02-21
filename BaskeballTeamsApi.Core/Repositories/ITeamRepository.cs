using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BasketballTeamsApi.Core.Entities;

namespace BasketballTeamsApi.Core.Repositories
{
    public interface ITeamRepository:IRepository<Team>
    {
        Task<Team> GetWithPlayersByIdAsync(int teamId);
    }
}
