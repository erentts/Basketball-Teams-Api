using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BasketballTeamsApi.Data.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public PlayerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Player> GetWithTeamByIdAsync(int playerId)
        {
            return await _appDbContext.Players.Include(p => p.Team).SingleOrDefaultAsync(p => p.Id == playerId);
        }
    }
}
