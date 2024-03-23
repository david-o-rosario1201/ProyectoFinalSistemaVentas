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
}
