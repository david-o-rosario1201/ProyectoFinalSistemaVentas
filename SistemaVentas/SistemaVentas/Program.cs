using Microsoft.EntityFrameworkCore;
using SistemaVentas.Components;
using SistemaVentas.Context.DAL;
using SistemaVentas.Services;
using SistemaVentas.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<Contexto>
    (o => o.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));

builder.Services.AddScoped<ClientesService>();
builder.Services.AddScoped<ProveedoresService>();
builder.Services.AddScoped<TiposContribuyenteService>();
builder.Services.AddScoped<ContactosService>();

//builder.Services.AddScoped(c =>
//    new HttpClient
//    {
//        BaseAddress = new Uri(builder.Configuration["RutaApi"] ?? "https://localhost:7150")
//    }
//);

builder.Services.AddScoped(c =>
	new HttpClient
	{
		BaseAddress = new Uri(builder.Configuration.GetSection("BaseUri").Value)
	}
);

builder.Services.AddHttpClient();
builder.Services.AddScoped<SistemaVentas.Services.Services.ProveedoresService>();
builder.Services.AddScoped<SistemaVentas.Services.Services.ClientesService>();
builder.Services.AddScoped<SistemaVentas.Services.Services.TiposContribuyenteService>();
builder.Services.AddScoped<SistemaVentas.Services.Services.ContactosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(SistemaVentas.Client._Imports).Assembly);

app.MapControllers();
app.Run();
