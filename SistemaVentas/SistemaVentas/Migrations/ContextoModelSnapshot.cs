﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentas.Context.DAL;

#nullable disable

namespace SistemaVentas.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("SistemaVentas.Models.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Descripcion = "Platos Entrantes",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 2,
                            Descripcion = "Platos Principales",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 3,
                            Descripcion = "Postres",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 4,
                            Descripcion = "Especiales del día",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 5,
                            Descripcion = "Platos de Temporada",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 6,
                            Descripcion = "Especialidades Extranjeras",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 7,
                            Descripcion = "Bebidas no alcohólicas",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 8,
                            Descripcion = "Bebidas alcohólicas",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 9,
                            Descripcion = "Cócteles",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            CategoriaId = 10,
                            Descripcion = "Tapas",
                            FechaCreacion = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Contactos", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ContactoId");

                    b.ToTable("Contactos");

                    b.HasData(
                        new
                        {
                            ContactoId = 1,
                            Descripcion = "Teléfono"
                        },
                        new
                        {
                            ContactoId = 2,
                            Descripcion = "Fax"
                        });
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.ProductoDetalle", b =>
                {
                    b.Property<int>("ProductoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoDetalleId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoDetalle");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Proveedores", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("RNC")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoContribuyente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.ProveedoresDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ContactoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("ProveedoresDetalle");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.TiposContribuyente", b =>
                {
                    b.Property<int>("TipoContribuyenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TipoContribuyenteId");

                    b.ToTable("TiposContribuyente");

                    b.HasData(
                        new
                        {
                            TipoContribuyenteId = 1,
                            Descripcion = "Persona Física"
                        },
                        new
                        {
                            TipoContribuyenteId = 2,
                            Descripcion = "Persona Jurídica"
                        });
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Devolucion")
                        .HasColumnType("REAL");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Pago")
                        .HasColumnType("REAL");

                    b.Property<float>("SubTotal")
                        .HasColumnType("REAL");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.VentasDetalle", b =>
                {
                    b.Property<int>("VentaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VentaDetalleId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.ProductoDetalle", b =>
                {
                    b.HasOne("SistemaVentas.Models.Models.Productos", null)
                        .WithMany("ProductoDetalle")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Productos", b =>
                {
                    b.HasOne("SistemaVentas.Models.Models.Categorias", null)
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.ProveedoresDetalle", b =>
                {
                    b.HasOne("SistemaVentas.Models.Models.Proveedores", null)
                        .WithMany("ProveedoresDetalle")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.VentasDetalle", b =>
                {
                    b.HasOne("SistemaVentas.Models.Models.Ventas", null)
                        .WithMany("VentaDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Categorias", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Productos", b =>
                {
                    b.Navigation("ProductoDetalle");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Proveedores", b =>
                {
                    b.Navigation("ProveedoresDetalle");
                });

            modelBuilder.Entity("SistemaVentas.Models.Models.Ventas", b =>
                {
                    b.Navigation("VentaDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
