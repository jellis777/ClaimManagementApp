
using Microsoft.EntityFrameworkCore;
using ClaimManagementAPI.Data;
using ClaimManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact",
    policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

// Add services to the container
builder.Services.AddControllers();

// Add Swagger (testing UI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ClaimService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=claims.db"));

var app = builder.Build();

app.UseCors("AllowReact");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
