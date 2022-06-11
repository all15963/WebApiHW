using Microsoft.EntityFrameworkCore;
using WebApiPractice.Data;

var builder = WebApplication.CreateBuilder(args);

// �ϥ�InMemory��Ʈw
builder.Services.AddDbContext<DataDbContext>(
    options => options.UseInMemoryDatabase("TempData")
    );
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
