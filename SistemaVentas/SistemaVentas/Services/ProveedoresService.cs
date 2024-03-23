﻿using SistemaVentas.Models.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;

namespace SistemaVentas.Services;

public class ProveedoresService(Contexto contexto)
{
    public async Task<List<Proveedores>> GetProveedores()
    {
        return await contexto.Proveedores.
            Include(p => p.ProveedoresDetalle).ToListAsync();
		//Select(p => new Proveedores()
		//{

		//}).ToListAsync();
	}

    public async Task<Proveedores> GetProveedor(short id)
    {
        return await contexto.Proveedores.AsNoTracking()
            .Include(d => d.ProveedoresDetalle)
            .FirstOrDefaultAsync(p => p.ProveedorId == id);
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

    public async Task<int> Delete(short id)
    {
        var eliminado = await contexto.Proveedores
            .Where(p => p.ProveedorId == id).ExecuteDeleteAsync();

        await contexto.SaveChangesAsync();
        return eliminado;
    }
}