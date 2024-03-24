using SistemaVentas.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Services.Services;

public class ClientesService
{
    private readonly HttpClient _httpClient;

    public ClientesService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Clientes>> GetClientes()
    {
        return await _httpClient.GetFromJsonAsync<List<Clientes>>("api/Clientes");
    }

	public async Task<Clientes> GetCliente(int id)
	{
		var cliente = await _httpClient.GetFromJsonAsync<Clientes>($"api/Clientes/{id}");
		return cliente;
	}

	public async Task<HttpResponseMessage> Save(Clientes Cliente)
	{
		return await _httpClient.PostAsJsonAsync("api/Clientes", Cliente);
	}

	public async Task<HttpResponseMessage> Update(Clientes cliente)
	{
		return await _httpClient.PutAsJsonAsync($"api/Clientes", cliente);
	}

	public async Task<HttpResponseMessage> Delete(int id)
	{
		return await _httpClient.DeleteAsync($"api/Clientes/{id}");
	}
}
