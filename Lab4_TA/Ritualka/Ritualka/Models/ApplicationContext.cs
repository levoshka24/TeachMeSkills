using Microsoft.EntityFrameworkCore;
namespace Ritualka.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<UserOrder> UsersOrders { get; set; }
        public DbSet<AddTovar> AddTovar { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
       
      
    }
}


