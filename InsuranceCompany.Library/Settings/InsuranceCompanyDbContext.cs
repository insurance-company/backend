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

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Accident> Accidents { get; set; }
        public DbSet<SignedPolicy> SignedPolicies {get; set;}
        public DbSet<Worker> Workers { get; set; }
        public DbSet<AidPackage> AidPackages { get; set; }
        public DbSet<TowTruck> TowTrucks { get; set; }
        public DbSet<TowingService> TowingServices { get; set;}
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Worker>().ToTable("Workers");
            modelBuilder.Entity<Agent>().ToTable("Agents");
            modelBuilder.Entity<Manager>().ToTable("Managers");
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
