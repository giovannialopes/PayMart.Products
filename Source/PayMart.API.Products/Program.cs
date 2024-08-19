using PayMart.Infrastructure.Products.Migrations;
using PayMart.Infrastructure.Products.Injection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(builder.Configuration);

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

await MigrationDb();

app.Run();

async Task MigrationDb()
{
    await using var scope = app.Services.CreateAsyncScope();

    await DataBaseMigration.MigrateDataBase(scope.ServiceProvider);
}