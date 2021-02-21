using System;
using System.Collections.Generic;
using System.Text;
using BasketballTeamsApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasketballTeamsApi.Data.Configurations
{
    public class TeamConfiguration:IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(50);
            builder.Property(t => t.Country).IsRequired();
            builder.Property(t => t.Country).HasMaxLength(50);
            builder.Property(t => t.CourtName).IsRequired();
            builder.Property(t => t.CourtName).HasMaxLength(50);
            builder.ToTable("Teams");
        }
    }
}
