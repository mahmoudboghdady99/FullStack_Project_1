﻿// <auto-generated />
using System;
using FirstApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstApp2.Migrations
{
    [DbContext(typeof(HrContext))]
    [Migration("20241027134900_personTable")]
    partial class personTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstApp2.Models.DepartmentsModel", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("DepartmentId");

                    b.ToTable("TbDepartments");
                });

            modelBuilder.Entity("FirstApp2.Models.EmployeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("TbEmployees");
                });

            modelBuilder.Entity("FirstApp2.Models.EmployeeVacation", b =>
                {
                    b.Property<int>("EmployeeVacationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeVacationId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("DateTime");

                    b.Property<int>("vacationType")
                        .HasColumnType("int");

                    b.HasKey("EmployeeVacationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TbEmployeeVacation");
                });

            modelBuilder.Entity("FirstApp2.Models.PersonModel", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.ToTable("TbPersons");
                });

            modelBuilder.Entity("FirstApp2.Models.EmployeeModel", b =>
                {
                    b.HasOne("FirstApp2.Models.DepartmentsModel", "TbDepartment")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstApp2.Models.PersonModel", "TbPerson")
                        .WithOne("TbEmployee")
                        .HasForeignKey("FirstApp2.Models.EmployeeModel", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbDepartment");

                    b.Navigation("TbPerson");
                });

            modelBuilder.Entity("FirstApp2.Models.EmployeeVacation", b =>
                {
                    b.HasOne("FirstApp2.Models.EmployeeModel", "TbEmployee")
                        .WithMany("EmployeeVacations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbEmployee");
                });

            modelBuilder.Entity("FirstApp2.Models.DepartmentsModel", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("FirstApp2.Models.EmployeeModel", b =>
                {
                    b.Navigation("EmployeeVacations");
                });

            modelBuilder.Entity("FirstApp2.Models.PersonModel", b =>
                {
                    b.Navigation("TbEmployee")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
