using BusinessObjects.Models;
using DataAccess.Mapping;
using Repositories.Interface;
using Repositories.Repository;
using Repository.Interface;
using Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddTransient<IProductRepository, ProductRepository>()
    .AddDbContext<MyDbContext>(opt =>
    builder.Configuration.GetConnectionString("MyStoreDB"));
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>()
    .AddDbContext<MyDbContext>(opt =>
    builder.Configuration.GetConnectionString("MyStoreDB"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
