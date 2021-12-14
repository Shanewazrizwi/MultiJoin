﻿// <auto-generated />
using System;
using CoreMultiJoinsProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreMultiJoinsProject.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CoreMultiJoinsProject.Models.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("statesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("statesId");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("departmentsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentsId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.States", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StateCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("countriesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("countriesId");

                    b.ToTable("states");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.Cities", b =>
                {
                    b.HasOne("CoreMultiJoinsProject.Models.States", "states")
                        .WithMany()
                        .HasForeignKey("statesId");

                    b.Navigation("states");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.Employee", b =>
                {
                    b.HasOne("CoreMultiJoinsProject.Models.Departments", "departments")
                        .WithMany()
                        .HasForeignKey("departmentsId");

                    b.Navigation("departments");
                });

            modelBuilder.Entity("CoreMultiJoinsProject.Models.States", b =>
                {
                    b.HasOne("CoreMultiJoinsProject.Models.Countries", "countries")
                        .WithMany()
                        .HasForeignKey("countriesId");

                    b.Navigation("countries");
                });
#pragma warning restore 612, 618
        }
    }
}
