﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVentas.DAL;

#nullable disable

namespace SistemaVentas.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240316223205_Contactos")]
    partial class Contactos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

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

            modelBuilder.Entity("Library.Models.ProveedoresDetalle", b =>
                {
                    b.HasOne("Library.Models.Proveedores", null)
                        .WithMany("ProveedoresDetalle")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Models.Proveedores", b =>
                {
                    b.Navigation("ProveedoresDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
