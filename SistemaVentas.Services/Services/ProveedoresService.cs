using SistemaVentas.Models.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemaVentas.Services.Services;

public class ProveedoresService
{
    private readonly HttpClient _httpClient;

    public ProveedoresService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Proveedores>> GetProveedores()
    {
        return await _httpClient.GetFromJsonAsync<List<Proveedores>>("api/Proveedores");
    }

    public async Task<Proveedores> GetProveedor(int id)
    {
        return await _httpClient.GetFromJsonAsync<Proveedores>($"api/Proveedores/{id}");
    }

    public async Task<HttpResponseMessage> Save(Proveedores proveedor)
    {
        return await _httpClient.PostAsJsonAsync("api/Proveedores", proveedor);
    }

    public async Task<HttpResponseMessage> Update(Proveedores proveedor)
    {
        return await _httpClient.PutAsJsonAsync($"api/Proveedores", proveedor);
    }

    public async Task<HttpResponseMessage> Delete(int id)
    {
        return await _httpClient.DeleteAsync($"api/Proveedores/{id}");
    }
}
