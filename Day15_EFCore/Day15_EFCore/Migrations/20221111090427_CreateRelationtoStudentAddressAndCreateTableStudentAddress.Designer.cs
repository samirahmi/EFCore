﻿// <auto-generated />
using System;
using Day15_EFCore.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Day15EFCore.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20221111090427_CreateRelationtoStudentAddressAndCreateTableStudentAddress")]
    partial class CreateRelationtoStudentAddressAndCreateTableStudentAddress
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Day15_EFCore.DataBase.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime?>("DoB")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte?>("Gender")
                        .HasColumnType("smallint");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasColumnType("VarChar(20)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("VarChar(100)");

                    b.HasKey("StudentId");

                    b.ToTable("Students", "dbo");
                });

            modelBuilder.Entity("Day15_EFCore.DataBase.StudentAddress", b =>
                {
                    b.Property<int>("StudentAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentAddressId"));

                    b.Property<string>("Address1")
                        .HasColumnType("VarChar(200)");

                    b.Property<string>("Address2")
                        .HasColumnType("VarChar(200)");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudentAddressId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentAddresses", "dbo");
                });

            modelBuilder.Entity("Day15_EFCore.DataBase.StudentAddress", b =>
                {
                    b.HasOne("Day15_EFCore.DataBase.Student", "Student")
                        .WithOne("StudentAddress")
                        .HasForeignKey("Day15_EFCore.DataBase.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Day15_EFCore.DataBase.Student", b =>
                {
                    b.Navigation("StudentAddress")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
