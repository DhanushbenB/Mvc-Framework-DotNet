﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using emp_details.Context;

#nullable disable

namespace emp_details.Migrations
{
    [DbContext(typeof(EmployeeDBcontext))]
    partial class EmployeeDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("emp_details.Models.Employee", b =>
                {
                    b.Property<int>("Empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Empid"));

                    b.Property<DateOnly>("Date_of_joining")
                        .HasColumnType("date");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("EmpSalary")
                        .HasColumnType("float");

                    b.HasKey("Empid");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
