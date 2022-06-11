using Microsoft.EntityFrameworkCore;
using WebApiPractice.Data;
using WebApiPractice.Services;

var builder = WebApplication.CreateBuilder(args);

// 使用InMemory資料庫
builder.Services.AddDbContext<DataDbContext>(
    options => options.UseInMemoryDatabase("TempData")
    );

// SetValueService DI
builder.Services.AddTransient<ISetValueService, SetValueService>();
// ValidValueService DI
builder.Services.AddTransient<IValidValueService, ValidValueService>();
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
