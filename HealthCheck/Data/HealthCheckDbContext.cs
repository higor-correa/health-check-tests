using HealthCheck.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;

namespace HealthCheck.Data
{
    public class HealthCheckDbContext : DbContext
    {
        public HealthCheckDbContext(DbContextOptions<HealthCheckDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
