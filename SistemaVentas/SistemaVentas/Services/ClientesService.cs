using SistemaVentas.Models.Models;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;

namespace SistemaVentas.Services;

public class ClientesService(Contexto contexto)
{
    public async Task<IEnumerable<Clientes>> GetClientes()
    {
        return await contexto.Clientes.ToListAsync();
        //Select(c => new Clientes()
        //{

        //}).ToListAsync();
    }

    public async Task<Clientes> GetCliente(int id)
    {
		var cliente = await contexto.Clientes.FirstOrDefaultAsync(c => c.ClienteId == id);
        return cliente;
	}

    public async Task<Clientes> Save(Clientes cliente)
    {
        contexto.Clientes.Add(cliente);
        await contexto.SaveChangesAsync();
        return cliente;
    }

    public async Task<Clientes> Update(Clientes cliente)
    {
        contexto.Clientes.Update(cliente);
        await contexto.SaveChangesAsync();
        return cliente;
    }

    public async Task Delete(int id)
    {
		var cliente = await contexto.Clientes.FindAsync(id);
		if (cliente != null)
		{
			contexto.Clientes.Remove(cliente);
			await contexto.SaveChangesAsync();
		}
	}
}
