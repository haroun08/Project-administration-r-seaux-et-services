using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Payments.Domain;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}