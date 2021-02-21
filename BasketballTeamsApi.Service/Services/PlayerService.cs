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
    public class PlayerService:Service<Player>,IPlayerService
    {
        public PlayerService(IUnitOfWork unitOfWork, IRepository<Player> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Player> GetWithTeamByIdAsync(int playerId)
        {
            return await _unitOfWork.Players.GetWithTeamByIdAsync(playerId);
        }
    }
}
