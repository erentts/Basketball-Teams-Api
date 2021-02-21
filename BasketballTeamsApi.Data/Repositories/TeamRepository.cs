using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BasketballTeamsApi.Data.Repositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public TeamRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Team> GetWithPlayersByIdAsync(int teamId)
        {
            return await _appDbContext.Teams.Include(t => t.Players).SingleOrDefaultAsync(t => t.Id == teamId);
        }
    }
}
