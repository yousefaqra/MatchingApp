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
    [Migration("20190328203733_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("MatchingApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApplicationId");

                    b.Property<string>("FirstName");

                    b.Property<double>("GPDA");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName");

                    b.Property<int>("NumberOfHourse");

                    b.Property<bool>("Toofel");

                    b.Property<string>("ZajelId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MatchingApp.Models.Student", b =>
                {
                    b.HasOne("MatchingApp.Models.Application")
                        .WithMany("Students")
                        .HasForeignKey("ApplicationId");
                });
#pragma warning restore 612, 618
        }
    }
}