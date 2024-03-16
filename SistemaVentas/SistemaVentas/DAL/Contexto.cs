using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentas.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Proveedores> Proveedores { get; set; }
    //public DbSet<Contactos> TipoTelefonos { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //    modelBuilder.Entity<Contactos>().HasData(new List<Contactos>
    //    {
    //        new Contactos { TipoId = 1, Descripcion = "Teléfono"},
    //        new Contactos { TipoId = 2, Descripcion = "Celular"},
    //        new Contactos { TipoId = 3, Descripcion = "Oficina"}
    //    });
    //}
}
