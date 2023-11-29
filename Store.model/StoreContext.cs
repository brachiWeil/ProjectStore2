using Microsoft.EntityFrameworkCore;
using Store.Model;

namespace Store.model
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
   
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ProductsOrders> ProductsOrders { get; set; }

       
    }
}