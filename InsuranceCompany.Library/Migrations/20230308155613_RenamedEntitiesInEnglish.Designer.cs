﻿// <auto-generated />
using System;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    [DbContext(typeof(InsuranceCompanyDbContext))]
    [Migration("20230308155613_RenamedEntitiesInEnglish")]
    partial class RenamedEntitiesInEnglish
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Accident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int?>("TowTruckId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("TowTruckId");

                    b.ToTable("Accidents");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PIB")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.AidPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<double>("Cover")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DurationInMonths")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("AidPackages");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("RegisterNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Years")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AidPackageId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AidPackageId");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.SignedPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AgentId")
                        .HasColumnType("integer");

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PolicyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("CarId");

                    b.HasIndex("PolicyId");

                    b.ToTable("SignedPolicies");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.TowTruck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.Property<int>("TowingServiceId")
                        .HasColumnType("integer");

                    b.Property<double>("TransportCapacity")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TowingServiceId");

                    b.ToTable("TowTrucks");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.TowingService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("BranchId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("TowingServices");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniqueMasterCitizenNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Worker", b =>
                {
                    b.HasBaseType("InsuranceCompany.Library.Core.Model.User");

                    b.Property<int?>("BossId")
                        .HasColumnType("integer");

                    b.HasIndex("BossId");

                    b.ToTable("Workers", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Agent", b =>
                {
                    b.HasBaseType("InsuranceCompany.Library.Core.Model.Worker");

                    b.Property<string>("LicenceNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Agents", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Manager", b =>
                {
                    b.HasBaseType("InsuranceCompany.Library.Core.Model.Worker");

                    b.Property<int>("ManagesTheBranchId")
                        .HasColumnType("integer");

                    b.HasIndex("ManagesTheBranchId");

                    b.ToTable("Managers", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Accident", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.TowTruck", "TowTruck")
                        .WithMany()
                        .HasForeignKey("TowTruckId");

                    b.Navigation("Car");

                    b.Navigation("TowTruck");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Branch", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Agency", "Agency")
                        .WithMany()
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Car", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Policy", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.AidPackage", "AidPackage")
                        .WithMany()
                        .HasForeignKey("AidPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AidPackage");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.SignedPolicy", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Policy", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Car");

                    b.Navigation("Policy");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.TowTruck", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.TowingService", "TowingService")
                        .WithMany()
                        .HasForeignKey("TowingServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TowingService");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.TowingService", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Worker", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Worker", "Boss")
                        .WithMany()
                        .HasForeignKey("BossId");

                    b.HasOne("InsuranceCompany.Library.Core.Model.User", null)
                        .WithOne()
                        .HasForeignKey("InsuranceCompany.Library.Core.Model.Worker", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boss");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Agent", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Worker", null)
                        .WithOne()
                        .HasForeignKey("InsuranceCompany.Library.Core.Model.Agent", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Manager", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Worker", null)
                        .WithOne()
                        .HasForeignKey("InsuranceCompany.Library.Core.Model.Manager", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Branch", "ManagesTheBranch")
                        .WithMany()
                        .HasForeignKey("ManagesTheBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagesTheBranch");
                });
#pragma warning restore 612, 618
        }
    }
}