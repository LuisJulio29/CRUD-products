using CRUD_products.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_products.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }
    }
}