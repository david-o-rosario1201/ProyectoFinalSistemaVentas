using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentas.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Proveedores> Proveedores { get; set; }
    public DbSet<TipoTelefonos> TipoTelefonos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TipoTelefonos>().HasData(new List<TipoTelefonos>
        {
            new TipoTelefonos { TipoId = 1, Descripcion = "Teléfono"},
            new TipoTelefonos { TipoId = 2, Descripcion = "Celular"},
            new TipoTelefonos { TipoId = 3, Descripcion = "Oficina"}
        });
    }
}
