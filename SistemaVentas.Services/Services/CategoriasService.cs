using SistemaVentas.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Services.Services;

public class CategoriasService
{
	private readonly HttpClient _httpClient;

	public CategoriasService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<List<Categorias>> GetCategorias()
	{
		var categorias = await _httpClient.GetFromJsonAsync<List<Categorias>>("api/Categorias");
		return categorias;
	}

	public async Task<Categorias> GetCategoria(int id)
	{
		var categoria = await _httpClient.GetFromJsonAsync<Categorias>($"api/Categorias/{id}");
		return categoria;
	}

	public async Task<HttpResponseMessage> Save(Categorias categoria)
	{
		return await _httpClient.PostAsJsonAsync("api/Categorias", categoria);
	}

	public async Task<HttpResponseMessage> Update(Categorias categoria)
	{
		return await _httpClient.PutAsJsonAsync($"api/Categorias", categoria);
	}

	public async Task<HttpResponseMessage> Delete(int id)
	{
		return await _httpClient.DeleteAsync($"api/Categorias/{id}");
	}
}
