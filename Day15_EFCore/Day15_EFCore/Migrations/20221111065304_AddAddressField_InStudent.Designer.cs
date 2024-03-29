﻿// <auto-generated />
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
    [Migration("20221111065304_AddAddressField_InStudent")]
    partial class AddAddressFieldInStudent
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

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VarChar(200)");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasColumnType("VarChar(20)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("VarChar(100)");

                    b.HasKey("StudentId");

                    b.ToTable("Students", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
