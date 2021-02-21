using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Repositories;
using BasketballTeamsApi.Core.UnitOfWorks;
using BasketballTeamsApi.Data.Repositories;

namespace BasketballTeamsApi.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        private PlayerRepository _playerRepository;
        private TeamRepository _teamRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IPlayerRepository Players => _playerRepository = _playerRepository ?? new PlayerRepository(_context);
        public ITeamRepository Teams => _teamRepository = _teamRepository ?? new TeamRepository(_context);
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
