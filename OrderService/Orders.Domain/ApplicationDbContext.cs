using Microsoft.EntityFrameworkCore;
using Orders.Domain.Entities;
using System.Reflection;

namespace Orders.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Entities.Order> Orders { get; set; }
        public DbSet<Product> Products {get;set;}
    }
}
