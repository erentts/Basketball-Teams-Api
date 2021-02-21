using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.Core.Repositories;
using BasketballTeamsApi.Core.Services;
using BasketballTeamsApi.Core.UnitOfWorks;

namespace BasketballTeamsApi.Service.Services
{
    public class TeamService:Service<Team>,ITeamService
    {
        public TeamService(IUnitOfWork unitOfWork, IRepository<Team> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Team> GetWithPlayersByIdAsync(int teamId)
        {
            return await _unitOfWork.Teams.GetWithPlayersByIdAsync(teamId);
        }
    }
}
