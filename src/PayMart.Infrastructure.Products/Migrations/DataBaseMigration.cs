using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Infrastructure.Products.DataAcess;

namespace PayMart.Infrastructure.Products.Migrations;

public class DataBaseMigration
{
    public async static Task MigrateDataBase(IServiceProvider serviceProvider)
    {
        var db = serviceProvider.GetRequiredService<DbProduct>();

        await db.Database.MigrateAsync();
    }
}
