using System;
using System.Collections.Generic;
using System.Text;
using BasketballTeamsApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasketballTeamsApi.Data.Seeds
{
    public class PlayerSeed : IEntityTypeConfiguration<Player>
    {
        private readonly int[] _ids;

        public PlayerSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasData(
                new Player { Id = 1, Name = "Stephen Curry", Age = 32, TeamId = _ids[0], JerseyNumber = 30, AveragePoints = 32.1m, AverageAssist = 9.1m, AverageRebound = 4.9m },
                new Player { Id = 2, Name = "Klay Thompson", Age = 31, TeamId = _ids[0], JerseyNumber = 11, AveragePoints = 27.3m, AverageAssist = 7.4m, AverageRebound = 6.5m },
                new Player { Id = 3, Name = "Draymond Green", Age = 30, TeamId = _ids[0], JerseyNumber = 23, AveragePoints = 14.5m, AverageAssist = 4.2m, AverageRebound = 8.7m },
                new Player { Id = 4, Name = "Damian Lillard", Age = 30, TeamId = _ids[1], JerseyNumber = 0, AveragePoints = 30.1m, AverageAssist = 6.1m, AverageRebound = 3.9m },
                new Player { Id = 5, Name = "Carmelo Anthony", Age = 36, TeamId = _ids[1], JerseyNumber = 00, AveragePoints = 21.8m, AverageAssist = 7.1m, AverageRebound = 6.6m },
                new Player { Id = 6, Name = "C. J. McCollum", Age = 29, TeamId = _ids[1], JerseyNumber = 3, AveragePoints = 26.1m, AverageAssist = 11.4m, AverageRebound = 5.2m }
                );
        }
    }
}
