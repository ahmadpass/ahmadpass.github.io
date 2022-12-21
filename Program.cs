using iNFO.API;
using iNFO.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ILandingPageService, LandingPageService>();
builder.Services.AddScoped<IProductsPageService, ProductsPageService>();
builder.Services.AddScoped<IListProductsPageService, ListProductsPageService>();
builder.Services.AddScoped<IProductDetailPageService, ProductDetailPageService>();
builder.Services.AddScoped<ITechnologyPageService, TechnologyPageService>();
builder.Services.AddScoped<IOperationPageService, OperationPageService>();
builder.Services.AddScoped<IRigPositionPageService, RigPositionPageService>();
builder.Services.AddScoped<INewsPageService, NewsPageService>();
builder.Services.AddScoped<IHSSEPageService, HSSEPageService>();

builder.Services.AddSingleton<DBConnection>();

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
