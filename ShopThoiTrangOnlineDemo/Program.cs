using Microsoft.EntityFrameworkCore;
using ShopThoiTrangOnlineDemo.Data;
using ShopThoiTrangOnlineDemo.Repositories;
using ShopThoiTrangOnlineDemo.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

//Add DI
AddDI(builder.Services);

builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddDbContext<DataContext>(options =>

{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopThoiTrang"));
});

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


void AddDI(IServiceCollection services)
{
    services.AddScoped<ProductRepository>();
    services.AddScoped<IProductService, ProductService>();
    services.AddScoped<ProductCategoryRepository>();
    services.AddScoped<IProductCategoryService, ProductCategoryService>();
    services.AddScoped<OrderRepository>();
    services.AddScoped<IOrderService, OrderService>();
    services.AddScoped<ProductImageRepository>();
    services.AddScoped<IProductImageService, ProductImageService>();
    services.AddScoped<OrderDetailRepository>();
    services.AddScoped<IOrderDetailService, OrderDetailService>();
}