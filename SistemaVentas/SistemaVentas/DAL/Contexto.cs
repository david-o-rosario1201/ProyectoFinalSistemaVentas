using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentas.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Proveedores> Proveedores { get; set; }
    public DbSet<Contactos> Contactos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Contactos>().HasData(new List<Contactos>
        {
            new Contactos { ContactoId = 1, Descripcion = "Teléfono"},
            new Contactos { ContactoId = 2, Descripcion = "Fax"}
        });
    }
}
