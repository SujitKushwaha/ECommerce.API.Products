using ECommerce.API.Products.Db;
using ECommerce.API.Products.Interface;
using ECommerce.API.Products.Providers;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ECommerce.API.Products.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IProductsProvider,ProductsProvider>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext <ProductsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerce"))
    //options.UseInMemoryDatabase("Products");
);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
