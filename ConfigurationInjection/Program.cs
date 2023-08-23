using ConfigurationInjection.Examples;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Nueva linea para inyectar la clase que creamos
//Inyectando objeto de Ejemplo 1
builder.Services.AddTransient<IService, ByIConfiguration>();
//Inyectando objeto de Ejemplo 2
builder.Services.AddTransient<IService2, ByIOptions>();
//Estableciendo que sección de configuraciones se mapeara
builder.Services.Configure<CustomFields>(builder.Configuration.GetSection("CustomFields"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
