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
    [Migration("20250104135044_initial")]
    partial class initial
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
                            Id = new Guid("976203ba-eba7-4866-9ad7-560196f45a38"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("ce91ad0c-2eeb-4b58-af26-f5ac6d20bb9e"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("ba5622e0-b234-4936-a1fc-a25121cb7d04"),
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
                            Id = new Guid("a5ffca80-706b-410e-bb1f-2cd810a50fff"),
                            Code = "NZ-NZL",
                            Name = "New Zealand",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("f019415e-286b-4848-8c84-6300d5048d3e"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("bf3764e1-7752-415c-a2db-6e10d928cf19"),
                            Code = "WGN",
                            Name = "Wellington",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("fffd1132-ab40-4474-9704-217330bb98cc"),
                            Code = "MEL",
                            Name = "Melbourne",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("c28a72ae-db27-445f-9e04-5c1c1919d74c"),
                            Code = "SDY",
                            Name = "Sydney",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("200fd4c0-7bf7-4b4d-8b36-62a8ee79dd4e"),
                            Code = "NSW",
                            Name = "New South Wales",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("78e1038b-5919-40a6-935d-a378d9ed53a9"),
                            Code = "VIC",
                            Name = "Victoria",
                            RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                        },
                        new
                        {
                            Id = new Guid("3607ddac-a200-4d89-bb92-c29d7de42fe7"),
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
