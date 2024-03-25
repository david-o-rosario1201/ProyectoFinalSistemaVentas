using SistemaVentas.Models.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;

namespace SistemaVentas.Services;

public class CategoriasService(Contexto contexto)
{
	public async Task<IEnumerable<Categorias>> GetCategorias()
	{
		return await contexto.Categorias.ToListAsync();
	}

	public async Task<Categorias> GetCategoria(int id)
	{
		var categoria = await contexto.Categorias.FirstOrDefaultAsync(c => c.CategoriaId == id);
		return categoria;
	}

	public async Task<Categorias> Save(Categorias categoria)
	{
		contexto.Categorias.Add(categoria);
		await contexto.SaveChangesAsync();
		return categoria;
	}

	public async Task<Categorias> Update(Categorias categoria)
	{
		contexto.Categorias.Update(categoria);
		await contexto.SaveChangesAsync();
		return categoria;
	}

	public async Task Delete(int id)
	{
		var categoria = await contexto.Categorias.FindAsync(id);
		if (categoria != null)
		{
			contexto.Categorias.Remove(categoria);
			await contexto.SaveChangesAsync();
		}
	}
}
