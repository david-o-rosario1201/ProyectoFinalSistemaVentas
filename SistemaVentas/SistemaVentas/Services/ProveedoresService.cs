using SistemaVentas.Models.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;

namespace SistemaVentas.Services;

public class ProveedoresService(Contexto contexto)
{
    public async Task<IEnumerable<Proveedores>> GetProveedores()
    {
		var proveedores = await contexto.Proveedores
	   .Include(p => p.ProveedoresDetalle)
	   .ToListAsync();

		return proveedores;
	}

    public async Task<Proveedores> GetProveedor(int id)
    {
		return await contexto.Proveedores
            .Include(d => d.ProveedoresDetalle).FirstOrDefaultAsync(p => p.ProveedorId == id);
    }

    public async Task<Proveedores> Save(Proveedores proveedor)
    {
        contexto.Proveedores.Add(proveedor);
        await contexto.SaveChangesAsync();
        return proveedor;
    }

    public async Task<Proveedores> Update(Proveedores proveedor)
    {
        contexto.Proveedores.Update(proveedor);
        await contexto.SaveChangesAsync();
        return proveedor;
    }

    public async Task Delete(int id)
    {
		var proveedor = await contexto.Proveedores.FindAsync(id);
		if (proveedor != null)
		{
			contexto.Proveedores.Remove(proveedor);
			await contexto.SaveChangesAsync();
		}
	}

	public async Task DeleteDetalle(int proveedorId, int detalleId)
	{
		var proveedor = await contexto.Proveedores
			.Include(d => d.ProveedoresDetalle)
			.FirstOrDefaultAsync(p => p.ProveedorId == proveedorId);

		if (proveedor != null)
		{
			var detalle = proveedor.ProveedoresDetalle.FirstOrDefault(d => d.DetalleId == detalleId);
			if(detalle != null)
			{
				proveedor.ProveedoresDetalle.Remove(detalle);
				await contexto.SaveChangesAsync();
			}
		}
	}
}
