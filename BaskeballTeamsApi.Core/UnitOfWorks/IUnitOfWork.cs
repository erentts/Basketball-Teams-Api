using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasketballTeamsApi.Core.Repositories;

namespace BasketballTeamsApi.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IPlayerRepository Players { get; }
        ITeamRepository Teams { get; }
        Task CommitAsync();
        void Commit();
    }
}
