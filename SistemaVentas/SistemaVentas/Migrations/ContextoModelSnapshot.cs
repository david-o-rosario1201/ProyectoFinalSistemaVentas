﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentas.DAL;

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

            modelBuilder.Entity("Library.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Descripcion = "Platos Entrantes"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Descripcion = "Platos Principales"
                        },
                        new
                        {
                            CategoriaId = 3,
                            Descripcion = "Postres"
                        },
                        new
                        {
                            CategoriaId = 4,
                            Descripcion = "Especiales del día"
                        },
                        new
                        {
                            CategoriaId = 5,
                            Descripcion = "Platos de Temporada"
                        },
                        new
                        {
                            CategoriaId = 6,
                            Descripcion = "Especialidades Extranjeras"
                        },
                        new
                        {
                            CategoriaId = 7,
                            Descripcion = "Bebidas no alcohólicas"
                        },
                        new
                        {
                            CategoriaId = 8,
                            Descripcion = "Bebidas alcohólicas"
                        },
                        new
                        {
                            CategoriaId = 9,
                            Descripcion = "Cócteles"
                        },
                        new
                        {
                            CategoriaId = 10,
                            Descripcion = "Tapas"
                        });
                });

            modelBuilder.Entity("Library.Models.Clientes", b =>
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

            modelBuilder.Entity("Library.Models.Contactos", b =>
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

            modelBuilder.Entity("Library.Models.ProductoDetalle", b =>
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

            modelBuilder.Entity("Library.Models.Productos", b =>
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

            modelBuilder.Entity("Library.Models.Proveedores", b =>
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

            modelBuilder.Entity("Library.Models.ProveedoresDetalle", b =>
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

            modelBuilder.Entity("Library.Models.TiposContribuyente", b =>
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

            modelBuilder.Entity("Library.Models.Ventas", b =>
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

            modelBuilder.Entity("Library.Models.VentasDetalle", b =>
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

            modelBuilder.Entity("Library.Models.ProductoDetalle", b =>
                {
                    b.HasOne("Library.Models.Productos", null)
                        .WithMany("ProductoDetalle")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Models.Productos", b =>
                {
                    b.HasOne("Library.Models.Categorias", null)
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("Library.Models.ProveedoresDetalle", b =>
                {
                    b.HasOne("Library.Models.Proveedores", null)
                        .WithMany("ProveedoresDetalle")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Models.VentasDetalle", b =>
                {
                    b.HasOne("Library.Models.Ventas", null)
                        .WithMany("VentaDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Models.Categorias", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Library.Models.Productos", b =>
                {
                    b.Navigation("ProductoDetalle");
                });

            modelBuilder.Entity("Library.Models.Proveedores", b =>
                {
                    b.Navigation("ProveedoresDetalle");
                });

            modelBuilder.Entity("Library.Models.Ventas", b =>
                {
                    b.Navigation("VentaDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
