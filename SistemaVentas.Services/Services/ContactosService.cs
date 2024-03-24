using SistemaVentas.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Services.Services;

public class ContactosService
{
	private readonly HttpClient _httpClient;

    public ContactosService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Contactos>> GetContactos()
    {
        return await _httpClient.GetFromJsonAsync<List<Contactos>>("api/Contactos");
    }
}
