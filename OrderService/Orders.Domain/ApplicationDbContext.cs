using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Orders.Domain;

public class ApplicationDbContext : DbContext {

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}