using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;
using SistemaVentas.Models.Models;

namespace SistemaVentas.Services;

public class ContactosService(Contexto contexto)
{
	public async Task<IEnumerable<Contactos>> GetContactos()
	{
		return await contexto.Contactos.ToListAsync();
	}
}
