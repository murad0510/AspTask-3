using AspTask_3.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspTask_3.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext>
            contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
