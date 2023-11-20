﻿// <auto-generated />
using CareProLearning.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CareProLearning.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120010345_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CareProLearning.Models.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModuleId"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            ModuleId = 1,
                            Category = "Labs",
                            Description = "How to access labs",
                            ThumbnailImagePath = "/images/Labs1.jpg",
                            Title = "Labs",
                            VideoUrl = "/videos/LabOrder.mp4"
                        },
                        new
                        {
                            ModuleId = 2,
                            Category = "Labs",
                            Description = "How to access labs 2",
                            ThumbnailImagePath = "/images/Lab2.jpg",
                            Title = "Math Basics",
                            VideoUrl = "/videos/Drugs.mp4"
                        },
                        new
                        {
                            ModuleId = 3,
                            Category = "Registration",
                            Description = "How to register a patient",
                            ThumbnailImagePath = "/images/register1.jpg",
                            Title = "Registration",
                            VideoUrl = "/videos/Register.mp4"
                        },
                        new
                        {
                            ModuleId = 4,
                            Category = "Registration",
                            Description = "How to register a patient 2",
                            ThumbnailImagePath = "/images/register2.jpg",
                            Title = "Registration Video Two",
                            VideoUrl = "/videos/Starting.mp4"
                        },
                        new
                        {
                            ModuleId = 5,
                            Category = "Vitals",
                            Description = "Vitals Vid",
                            ThumbnailImagePath = "/images/Vitals1.jpg",
                            Title = "Vitals Video One",
                            VideoUrl = "/videos/Vitals.mp4"
                        },
                        new
                        {
                            ModuleId = 6,
                            Category = "Vitals",
                            Description = "Vitals Vid Two",
                            ThumbnailImagePath = "/images/Vitals2.jpg",
                            Title = "Vitals Video Two",
                            VideoUrl = "/videos/Visit.mp4"
                        },
                        new
                        {
                            ModuleId = 7,
                            Category = "Reports",
                            Description = "MER Reports",
                            ThumbnailImagePath = "/images/report1.jpeg",
                            Title = "Reports",
                            VideoUrl = "/videos/ARTClient.mp4"
                        },
                        new
                        {
                            ModuleId = 8,
                            Category = "Reports",
                            Description = "MER Reports Video Two",
                            ThumbnailImagePath = "/images/report2.jpg",
                            Title = "Reports",
                            VideoUrl = "/videos/Reports.mp4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
