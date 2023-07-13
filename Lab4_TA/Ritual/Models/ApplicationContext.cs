using Microsoft.EntityFrameworkCore;
using Ritual.Models;

namespace Ritual.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<UserOrder> USersOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MainOrder> MainOrders { get; set; }
    }
}
