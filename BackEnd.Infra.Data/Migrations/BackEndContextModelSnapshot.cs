﻿// <auto-generated />
using System;
using BackEnd.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Infra.Data.Migrations
{
    [DbContext(typeof(BackEndContext))]
    partial class BackEndContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Domain.Models.Seguradora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Ativo")
                        .HasDefaultValue(true);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasMaxLength(14);

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CriadoEm")
                        .HasDefaultValue(null);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Seguradora");

                    b.HasData(
                        new { Id = 1, Ativo = true, Cnpj = "24751734000170", CriadoEm = new DateTime(2020, 1, 6, 2, 34, 35, 226, DateTimeKind.Local), Nome = "Malu e Milena Seguradora" },
                        new { Id = 2, Ativo = true, Cnpj = "76395991000110", CriadoEm = new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), Nome = "Bruno e Kauê Seguradora" },
                        new { Id = 3, Ativo = true, Cnpj = "42597748000163", CriadoEm = new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), Nome = "Clarice e Osvaldo Seguradora" },
                        new { Id = 4, Ativo = true, Cnpj = "08141045000198", CriadoEm = new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), Nome = "Luan e Emanuel Seguradora" },
                        new { Id = 5, Ativo = true, Cnpj = "25934594000139", CriadoEm = new DateTime(2020, 1, 6, 2, 34, 35, 227, DateTimeKind.Local), Nome = "Carla e Severino Seguradora" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
