﻿// <auto-generated />
using System;
using InsuranceCompany.Library.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    [DbContext(typeof(InsuranceCompanyDbContext))]
    partial class InsuranceCompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Agencija", b =>
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

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PIB")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Agencija");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Auto", b =>
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

                    b.Property<int>("Godiste")
                        .HasColumnType("integer");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegistarskiBroj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VlasnikId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VlasnikId");

                    b.ToTable("Auti");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Filijala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AgencijaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AgencijaId");

                    b.ToTable("Filijale");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Nesreca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AutoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SleperId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AutoId");

                    b.HasIndex("SleperId");

                    b.ToTable("Nesrece");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.PaketPomoci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<double>("Cena")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Pokrice")
                        .HasColumnType("double precision");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TrajanjeUMesecima")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PaketiPomoci");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Polisa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PaketPomociId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PaketPomociId");

                    b.ToTable("Polise");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.PotpisanaPolisa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("AgentId")
                        .HasColumnType("integer");

                    b.Property<int>("AutoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PolisaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("AutoId");

                    b.HasIndex("PolisaId");

                    b.ToTable("PotpisanePolise");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.SlepSluzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("FilijalaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FilijalaId");

                    b.ToTable("SlepSluzbe");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Sleper", b =>
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

                    b.Property<double>("Duzina")
                        .HasColumnType("double precision");

                    b.Property<double>("Nosivost")
                        .HasColumnType("double precision");

                    b.Property<double>("Sirina")
                        .HasColumnType("double precision");

                    b.Property<int>("SlepSluzbaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SlepSluzbaId");

                    b.ToTable("Sleperi");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BrojTelefona")
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

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Pol")
                        .HasColumnType("integer");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Radnik", b =>
                {
                    b.HasBaseType("InsuranceCompany.Library.Core.Model.User");

                    b.Property<int>("SefId")
                        .HasColumnType("integer");

                    b.Property<int>("Tip")
                        .HasColumnType("integer");

                    b.HasIndex("SefId");

                    b.ToTable("Radnici", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Agent", b =>
                {
                    b.HasBaseType("InsuranceCompany.Library.Core.Model.Radnik");

                    b.Property<string>("BrojLicence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Agenti", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Menadzer", b =>
                {
                    b.HasBaseType("InsuranceCompany.Library.Core.Model.Radnik");

                    b.Property<int>("RukovodiFilijalomId")
                        .HasColumnType("integer");

                    b.HasIndex("RukovodiFilijalomId");

                    b.ToTable("Menadzeri", (string)null);
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Auto", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.User", "Vlasnik")
                        .WithMany()
                        .HasForeignKey("VlasnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vlasnik");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Filijala", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Agencija", "Agencija")
                        .WithMany()
                        .HasForeignKey("AgencijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agencija");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Nesreca", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Sleper", "Sleper")
                        .WithMany()
                        .HasForeignKey("SleperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auto");

                    b.Navigation("Sleper");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Polisa", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.PaketPomoci", "PaketPomoci")
                        .WithMany()
                        .HasForeignKey("PaketPomociId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaketPomoci");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.PotpisanaPolisa", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Polisa", "Polisa")
                        .WithMany()
                        .HasForeignKey("PolisaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Auto");

                    b.Navigation("Polisa");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.SlepSluzba", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Filijala", "Filijala")
                        .WithMany()
                        .HasForeignKey("FilijalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filijala");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Sleper", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.SlepSluzba", "SlepSluzba")
                        .WithMany()
                        .HasForeignKey("SlepSluzbaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SlepSluzba");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Radnik", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.User", null)
                        .WithOne()
                        .HasForeignKey("InsuranceCompany.Library.Core.Model.Radnik", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Radnik", "Sef")
                        .WithMany()
                        .HasForeignKey("SefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sef");
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Agent", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Radnik", null)
                        .WithOne()
                        .HasForeignKey("InsuranceCompany.Library.Core.Model.Agent", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InsuranceCompany.Library.Core.Model.Menadzer", b =>
                {
                    b.HasOne("InsuranceCompany.Library.Core.Model.Radnik", null)
                        .WithOne()
                        .HasForeignKey("InsuranceCompany.Library.Core.Model.Menadzer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceCompany.Library.Core.Model.Filijala", "RukovodiFilijalom")
                        .WithMany()
                        .HasForeignKey("RukovodiFilijalomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RukovodiFilijalom");
                });
#pragma warning restore 612, 618
        }
    }
}
