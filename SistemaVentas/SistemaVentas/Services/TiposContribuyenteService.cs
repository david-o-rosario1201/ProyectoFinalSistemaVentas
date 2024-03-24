using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;
using SistemaVentas.Models.Models;

namespace SistemaVentas.Services;

public class TiposContribuyenteService(Contexto contexto)
{
	public async Task<IEnumerable<TiposContribuyente>> GetTiposContribuyentes()
	{
		var response = await contexto.TiposContribuyente.ToListAsync();
		return response;
	}
}
