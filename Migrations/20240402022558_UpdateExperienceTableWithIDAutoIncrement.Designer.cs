﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend_portfolio.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240402022558_UpdateExperienceTableWithIDAutoIncrement")]
    partial class UpdateExperienceTableWithIDAutoIncrement
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Experience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("highlightSkills")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("longDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nameOfCompany")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("period")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("shortDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Experiences");
                });
#pragma warning restore 612, 618
        }
    }
}
