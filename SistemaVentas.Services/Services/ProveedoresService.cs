using SistemaVentas.Models.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Text;


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
		var proveedores = await _httpClient.GetFromJsonAsync<List<Proveedores>>("api/Proveedores");
		return proveedores;
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

	public async Task<HttpResponseMessage> DeleteDetalle(int proveedorId, int detalleId)
	{
		return await _httpClient.DeleteAsync($"api/Proveedores/{proveedorId}/Detalle/{detalleId}");
	}
}
