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
	public DbSet<Productos> Productos { get; set; }
	public DbSet<Categorias> Categorias { get; set; }
	public DbSet<Ventas> Ventas { get; set; }
	public DbSet<Clientes> Clientes { get; set; }

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
		modelBuilder.Entity<Categorias>().HasData(
			new Categorias() { CategoriaId = 1, Descripcion = "Platos Entrantes" },
			new Categorias() { CategoriaId = 2, Descripcion = "Platos Principales" },
			new Categorias() { CategoriaId = 3, Descripcion = "Postres" },
			new Categorias() { CategoriaId = 4, Descripcion = "Especiales del día" },
			new Categorias() { CategoriaId = 5, Descripcion = "Platos de Temporada" },
			new Categorias() { CategoriaId = 6, Descripcion = "Especialidades Extranjeras" },
			new Categorias() { CategoriaId = 7, Descripcion = "Bebidas no alcohólicas" },
			new Categorias() { CategoriaId = 8, Descripcion = "Bebidas alcohólicas" },
			new Categorias() { CategoriaId = 9, Descripcion = "Cócteles" },
			new Categorias() { CategoriaId = 10, Descripcion = "Tapas" }
		);
	}
}
