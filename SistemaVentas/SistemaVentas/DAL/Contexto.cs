using SistemaVentas.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentas.Context.DAL;

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
		modelBuilder.Entity<Categorias>().HasData(new List<Categorias>
		{
			new Categorias() { CategoriaId = 1, Descripcion = "Platos Entrantes" , FechaCreacion = new DateTime(2024, 3, 24)},
			new Categorias() { CategoriaId = 2, Descripcion = "Platos Principales", FechaCreacion = new DateTime(2024, 3, 24)},
			new Categorias() { CategoriaId = 3, Descripcion = "Postres" , FechaCreacion = new DateTime(2024, 3, 24) },
			new Categorias() { CategoriaId = 4, Descripcion = "Especiales del día" , FechaCreacion = new DateTime(2024, 3, 24) },
			new Categorias() { CategoriaId = 5, Descripcion = "Platos de Temporada" , FechaCreacion = new DateTime(2024, 3, 24)},
			new Categorias() { CategoriaId = 6, Descripcion = "Especialidades Extranjeras" ,  FechaCreacion = new DateTime(2024, 3, 24) },
			new Categorias() { CategoriaId = 7, Descripcion = "Bebidas no alcohólicas" ,  FechaCreacion = new DateTime(2024, 3, 24) },
			new Categorias() { CategoriaId = 8, Descripcion = "Bebidas alcohólicas" , FechaCreacion = new DateTime(2024, 3, 24)},
			new Categorias() { CategoriaId = 9, Descripcion = "Cócteles" , FechaCreacion = new DateTime(2024, 3, 24)},
			new Categorias() { CategoriaId = 10, Descripcion = "Tapas" , FechaCreacion = new DateTime(2024, 3, 24)}
		});
	}
}
