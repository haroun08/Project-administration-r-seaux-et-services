using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Payments.Domain;

public static class DI {
    public static IServiceCollection AddDatabase(this IServiceCollection services , IConfiguration cnnstring){
        return services;
    }
}