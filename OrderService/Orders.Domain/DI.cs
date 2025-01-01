using Microsoft.Extensions.DependencyInjection;

namespace Orders.Domain;

public static class DI {
    public static IServiceCollection AddDatabase(this IServiceCollection services){
        return services;
        
    }
}