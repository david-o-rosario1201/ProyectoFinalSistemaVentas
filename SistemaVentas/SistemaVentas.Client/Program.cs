using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SistemaVentas.Services.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddScoped(http => new HttpClient
{
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<ClientesService>();
builder.Services.AddScoped<ProveedoresService>();

await builder.Build().RunAsync();
