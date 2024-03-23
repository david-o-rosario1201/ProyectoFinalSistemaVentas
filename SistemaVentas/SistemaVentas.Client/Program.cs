using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SistemaVentas.Services.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

await builder.Build().RunAsync();
