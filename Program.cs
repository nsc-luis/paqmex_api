using Microsoft.EntityFrameworkCore;
using PAQMEX_API;
using PAQMEX_API.Models.ENTREGAS;
using PAQMEX_API.Models.JPG;
using PAQMEX_API.Models.PAQUETERIAPQ;
using PAQMEX_API.Security;
using PAQMEX_API.Services.JPG;
using PAQMEX_API.Services.PAQUETERIAPQ;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IJPGService, JPGService>();
builder.Services.AddScoped<IPAQUETERIAPQService, PAQUETERIAPQService>();
builder.Services.AddScoped<IAuthUrreaService, AuthUrreaService>();
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<Microsoft.AspNetCore.Authentication.AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null);
builder.Services.AddDbContext<PaqueteriapqContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PAQUETERIAPQ"));
});
builder.Services.AddDbContext<ENTREGASContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ENTREGAS"));
});
builder.Services.AddDbContext<JPGContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("JPG"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options => options.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi2_0);
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
