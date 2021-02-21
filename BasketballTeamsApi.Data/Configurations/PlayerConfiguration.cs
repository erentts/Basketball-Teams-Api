using System;
using System.Collections.Generic;
using System.Text;
using BasketballTeamsApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasketballTeamsApi.Data.Configurations
{
    public class PlayerConfiguration:IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.JerseyNumber).IsRequired();
            builder.Property(p => p.AveragePoints).IsRequired();
            builder.Property(p => p.AveragePoints).HasColumnType("decimal(4,1)");
            builder.Property(p => p.AverageAssist).IsRequired();
            builder.Property(p => p.AverageAssist).HasColumnType("decimal(4,1)");
            builder.Property(p => p.AverageRebound).IsRequired();
            builder.Property(p => p.AverageRebound).HasColumnType("decimal(4,1)");
            builder.ToTable("Players");
        }
    }
}
