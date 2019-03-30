﻿// <auto-generated />
using System;
using MatchingApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MatchingApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190330120818_AddDotcitorTable")]
    partial class AddDotcitorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MatchingApp.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("completed");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasAlternateKey("name")
                        .HasName("AlternaeveKey_ApplicationName");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("MatchingApp.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("applicationId");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.HasIndex("applicationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MatchingApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<double>("GPDA")
                        .HasMaxLength(32);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("NumberOfHourse");

                    b.Property<bool>("Toofel");

                    b.Property<string>("ZajelId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("applicationId");

                    b.HasKey("Id");

                    b.HasAlternateKey("ZajelId")
                        .HasName("AlternaeveKey_ZajelId");

                    b.HasIndex("applicationId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MatchingApp.Models.Doctor", b =>
                {
                    b.HasOne("MatchingApp.Models.Application", "application")
                        .WithMany("Doctors")
                        .HasForeignKey("applicationId");
                });

            modelBuilder.Entity("MatchingApp.Models.Student", b =>
                {
                    b.HasOne("MatchingApp.Models.Application", "application")
                        .WithMany("Students")
                        .HasForeignKey("applicationId");
                });
#pragma warning restore 612, 618
        }
    }
}