using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MatchingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Application> Applications { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasAlternateKey(x => x.ZajelId)
                .HasName("AlternaeveKey_ZajelId");

            modelBuilder.Entity<Application>()
                .HasAlternateKey(x => x.name)
                .HasName("AlternaeveKey_ApplicationName");
        }
    }
}
