﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tablet.Data;

namespace Tablet.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tablet.Data.Models.GeneralDevelopment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Forecast")
                        .HasColumnType("int");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GeneralDevelopmentModels");
                });

            modelBuilder.Entity("Tablet.Data.Models.Project", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technology")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Tablet.Data.Models.ProjectProblems", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Problem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectProblems");
                });

            modelBuilder.Entity("Tablet.Data.Models.Structure", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Proportion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Structures");
                });

            modelBuilder.Entity("Tablet.Data.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
