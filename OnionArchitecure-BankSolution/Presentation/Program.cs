using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Shto shërbimet e kontrollerëve
builder.Services.AddControllers();

// Konfiguro EF Core me connection string nga appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Regjistro Repository-t
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IAllocationRepository, AllocationRepository>();

// Regjistro shërbimet e aplikacionit
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<DepartmentService>();
// Shtoni edhe shërbime për Project, Location dhe Allocation sipas nevojës

// Shto Swagger për dokumentim API-jeve
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Konfigurimi i middleware-ve
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();