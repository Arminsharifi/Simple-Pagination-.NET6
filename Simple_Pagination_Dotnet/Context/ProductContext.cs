using Microsoft.EntityFrameworkCore;
using Simple_Pagination_Dotnet.Mappings;
using Simple_Pagination_Dotnet.Models;

namespace Simple_Pagination_Dotnet.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}