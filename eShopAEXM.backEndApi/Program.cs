using eShopAEXM.Application.IRepository;
using eShopAEXM.Application.Repository;
using eShopAEXM.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSqlServer<eShopAEXMContext>("Data Source=.\\SQLEXPRESS;Initial Catalog=eShopAEXMDb;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IProductRepo,ProductRepo>();
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
