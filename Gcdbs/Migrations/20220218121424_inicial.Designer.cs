﻿// <auto-generated />
using System;
using Gcdbs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gcdbs.Migrations
{
    [DbContext(typeof(GcDbContext))]
    [Migration("20220218121424_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gcdbs.Models.Modelo", b =>
                {
                    b.Property<int>("IdModelo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MontadoraIdMontadora")
                        .HasColumnType("int");

                    b.Property<string>("NomeModelo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdModelo");

                    b.HasIndex("MontadoraIdMontadora");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("Gcdbs.Models.Montadora", b =>
                {
                    b.Property<int>("IdMontadora")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeMontadora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMontadora");

                    b.ToTable("Montadoras");
                });

            modelBuilder.Entity("Gcdbs.Models.Modelo", b =>
                {
                    b.HasOne("Gcdbs.Models.Montadora", null)
                        .WithMany("Modelos")
                        .HasForeignKey("MontadoraIdMontadora");
                });
#pragma warning restore 612, 618
        }
    }
}