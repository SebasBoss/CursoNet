﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ExamenFinalContext))]
    partial class ExamenFinalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.HistorialMovimientosStock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("DATETIME");

                    b.Property<int>("StockAnterior")
                        .HasColumnType("INT");

                    b.Property<Guid>("StockId")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.Property<int>("StockNuevo")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("HistorialMovimientosStocks");
                });

            modelBuilder.Entity("DataAccess.Models.Libro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("BIT");

                    b.Property<string>("Nombre")
                        .HasColumnType("VARCHAR(500)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("MONEY");

                    b.HasKey("Id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("DataAccess.Models.LogError", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Error")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("LogErrores");
                });

            modelBuilder.Entity("DataAccess.Models.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INT");

                    b.Property<Guid>("LibroId")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("DataAccess.Models.HistorialMovimientosStock", b =>
                {
                    b.HasOne("DataAccess.Models.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Stock", b =>
                {
                    b.HasOne("DataAccess.Models.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
