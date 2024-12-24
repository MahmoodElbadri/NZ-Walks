﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZ_Walks.api.Data;

#nullable disable

namespace NZ_Walks.api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241224213634_SeedingData")]
    partial class SeedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZ_Walks.api.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("21f88c58-c1b2-4ffd-8077-52213d8ba026"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("1db32833-700c-46af-8710-28c3f59d42c3"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("b778f9d5-8358-488a-a578-5e04b92ff5b6"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZ_Walks.api.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2730e821-5dd2-450d-94d7-a5368bfc5626"),
                            Code = "NZ-NZL",
                            Name = "New Zealand",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("f1e5872f-cbe6-4a82-af17-e04cc262ad64"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("756d68e3-d985-4b98-a76a-a26723f85c1f"),
                            Code = "WGN",
                            Name = "Wellington",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("a8bea56d-4c53-45d7-9a8e-3301c6fba50d"),
                            Code = "MEL",
                            Name = "Melbourne",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("412982ef-2339-4782-8315-812513403af2"),
                            Code = "SDY",
                            Name = "Sydney",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("6dfb2724-3461-4fec-901f-08cf1e6fc308"),
                            Code = "NSW",
                            Name = "New South Wales",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("cb096dd6-4a47-491d-b905-ae8f6bb54b56"),
                            Code = "VIC",
                            Name = "Victoria",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("90107d03-9136-4887-8bc0-3e52b5eb0a96"),
                            Code = "QLD",
                            Name = "Queensland",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        });
                });

            modelBuilder.Entity("NZ_Walks.api.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZ_Walks.api.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZ_Walks.api.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZ_Walks.api.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
