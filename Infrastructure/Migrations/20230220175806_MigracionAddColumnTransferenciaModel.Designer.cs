﻿// <auto-generated />
using System;
using Infrastructure.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230220175806_MigracionAddColumnTransferenciaModel")]
    partial class MigracionAddColumnTransferenciaModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Cuenta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("Borrado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<long>("NumeroCuenta")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(20,8)");

                    b.Property<int>("TipoCuenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cuenta");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Borrado = false,
                            FechaCreado = new DateTime(2023, 2, 20, 11, 58, 6, 718, DateTimeKind.Local).AddTicks(8943),
                            NumeroCuenta = 1L,
                            Saldo = 900m,
                            TipoCuenta = 1
                        },
                        new
                        {
                            Id = 2L,
                            Borrado = false,
                            FechaCreado = new DateTime(2023, 2, 20, 11, 58, 6, 718, DateTimeKind.Local).AddTicks(8956),
                            NumeroCuenta = 1L,
                            Saldo = 900m,
                            TipoCuenta = 1
                        },
                        new
                        {
                            Id = 3L,
                            Borrado = false,
                            FechaCreado = new DateTime(2023, 2, 20, 11, 58, 6, 718, DateTimeKind.Local).AddTicks(8958),
                            NumeroCuenta = 1L,
                            Saldo = 900m,
                            TipoCuenta = 1
                        });
                });

            modelBuilder.Entity("Domain.Transferencia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("Borrado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificado")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdCuentaDestino")
                        .HasColumnType("bigint");

                    b.Property<long>("IdCuentaOrigen")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(20,8)");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transferencia");
                });
#pragma warning restore 612, 618
        }
    }
}
