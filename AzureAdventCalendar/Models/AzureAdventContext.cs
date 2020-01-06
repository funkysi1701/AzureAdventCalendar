using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace AzureAdventCalendar.Models
{
    public partial class AzureAdventContext : DbContext
    {
        private IConfiguration _config;

        public AzureAdventContext()
        {
        }

        public AzureAdventContext(DbContextOptions<AzureAdventContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }

        public virtual DbSet<Reindeer> Reindeer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("Database"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reindeer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}