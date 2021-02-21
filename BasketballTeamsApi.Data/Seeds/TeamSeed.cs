using System;
using System.Collections.Generic;
using System.Text;
using BasketballTeamsApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasketballTeamsApi.Data.Seeds
{
    public class TeamSeed:IEntityTypeConfiguration<Team>
    {
        private readonly int[] _ids;

        public TeamSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team { Id = _ids[0], Name = "Golden State Warriors", Country = "USA", CourtName = "Case Center"},
                new Team { Id = _ids[1], Name = "Portland Trail Blazers", Country = "USA", CourtName = "Moda Center at the Rose Quarter" }
            );
        }
    }
}
