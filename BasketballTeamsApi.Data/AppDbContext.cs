using System;
using System.Collections.Generic;
using System.Text;
using BasketballTeamsApi.Core.Entities;
using BasketballTeamsApi.Data.Configurations;
using BasketballTeamsApi.Data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace BasketballTeamsApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new TeamSeed(new int[] { 1, 2 }));
        }
    }
}
