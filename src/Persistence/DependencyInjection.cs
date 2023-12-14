using Application.Abstractions.Data;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Services;

namespace Persistence;

public static class DependencyInjection
{
    // 須安裝套件(Microsoft.Extensions.DependencyInjection)
    // 才能取得IServiceCollection
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        // 利用Extension Method把DB連線類別註冊到.NET的服務容器
        services.AddScoped<IDbContext, SqlServerConnection>();

        return services;
    }
}
