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

    public async Task<Clientes> GetCliente(short id)
    {
        return await contexto.Clientes.AsNoTracking()
                                    .FirstOrDefaultAsync(c => c.ClienteId == id);
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

    public async Task<int> Delete(short id)
    {
        var eliminado = await contexto.Clientes
            .Where(c => c.ClienteId == id)
            .ExecuteDeleteAsync();

        await contexto.SaveChangesAsync();
        return eliminado;
    }
}
