using InsuranceCompany.Library.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Settings
{
    public class InsuranceCompanyDbContext : DbContext
    {

        public InsuranceCompanyDbContext(DbContextOptions<InsuranceCompanyDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Agencija> Agencija { get; set; }
        public DbSet<Agent> Agenti { get; set; }
        public DbSet<Auto> Auti { get; set; }
        public DbSet<Filijala> Filijale { get; set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Menadzer> Menadzeri { get; set; }
        public DbSet<Nesreca> Nesrece { get; set; }
        public DbSet<Polisa> Polise { get; set; }
        public DbSet<PotpisanaPolisa> PotpisanePolise {get; set;}
        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<PaketPomoci> PaketiPomoci { get; set; }
        public DbSet<Sleper> Sleperi { get; set; }
        public DbSet<SlepSluzba> SlepSluzbe { get; set;}
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Kupac>().ToTable("Kupci");
            modelBuilder.Entity<Radnik>().ToTable("Radnici");
            modelBuilder.Entity<Agent>().ToTable("Agenti");
            modelBuilder.Entity<Menadzer>().ToTable("Menadzeri");
        }

        public override int SaveChanges()
        {

            IEnumerable<EntityEntry> entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is Entity && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (EntityEntry entityEntry in entries)
            {
                ((Entity)entityEntry.Entity).DateUpdated = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((Entity)entityEntry.Entity).DateCreated = DateTime.Now;
                    ((Entity)entityEntry.Entity).Deleted = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
