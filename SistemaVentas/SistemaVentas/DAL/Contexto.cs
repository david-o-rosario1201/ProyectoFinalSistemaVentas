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
    public DbSet<TiposContribuyente> TiposContribuyente { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Contactos>().HasData(new List<Contactos>
        {
            new Contactos { ContactoId = 1, Descripcion = "Teléfono"},
            new Contactos { ContactoId = 2, Descripcion = "Fax"}
        });

		modelBuilder.Entity<TiposContribuyente>().HasData(new List<TiposContribuyente>
		{
			new TiposContribuyente { TipoContribuyenteId = 1, Descripcion = "Persona Física"},
			new TiposContribuyente { TipoContribuyenteId = 2, Descripcion = "Persona Jurídica"}
		});
	}
}
