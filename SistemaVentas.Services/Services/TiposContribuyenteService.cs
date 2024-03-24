using SistemaVentas.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Services.Services;

public class TiposContribuyenteService
{
	private readonly HttpClient _httpClient;

	public TiposContribuyenteService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<List<TiposContribuyente>> GetTiposContribuyentes()
	{
		return await _httpClient.GetFromJsonAsync<List<TiposContribuyente>>("api/TiposContribuyentes");
	}
}
