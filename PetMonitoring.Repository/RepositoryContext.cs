using Microsoft.EntityFrameworkCore;
using PetMonitoring.Entity.Model;
using PetMonitoring.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Device>? Device { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<Role>? Role { get; set; }
        public DbSet<HeartRateData>? HeartRateData { get; set; }
        public DbSet<TemperatureData>? TemperatureData { get; set; }
        public DbSet<MovementData>? MovementData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
