﻿// <auto-generated />
using System;
using EFDAL.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFDAL.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200214090620_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFDAL.Models.employee", b =>
                {
                    b.Property<string>("eid")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("designation")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ename")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("joindate")
                        .HasColumnType("Date");

                    b.Property<int>("pid")
                        .HasColumnType("int");

                    b.Property<decimal?>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("eid");

                    b.HasIndex("pid");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EFDAL.Models.project", b =>
                {
                    b.Property<int>("pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("enddate")
                        .HasColumnType("Date");

                    b.Property<string>("pname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("startdate")
                        .HasColumnType("Date");

                    b.HasKey("pid");

                    b.ToTable("project");
                });

            modelBuilder.Entity("EFDAL.Models.employee", b =>
                {
                    b.HasOne("EFDAL.Models.project", "project")
                        .WithMany("employees")
                        .HasForeignKey("pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
