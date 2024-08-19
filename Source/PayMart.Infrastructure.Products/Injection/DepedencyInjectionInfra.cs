﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Domain.Products.Interface.Database;
using PayMart.Infrastructure.Products.DataAcess;
using PayMart.Infrastructure.Products.Repositories;

namespace PayMart.Infrastructure.Products.Injection;

public static class DepedencyInjectionInfra
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
    }
    
    public static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICommit, ProductRepository>();

        var connectionString = configuration.GetConnectionString("Connection");
        services.AddDbContext<DbProduct>(config => config.UseSqlServer(connectionString));
    }
}
