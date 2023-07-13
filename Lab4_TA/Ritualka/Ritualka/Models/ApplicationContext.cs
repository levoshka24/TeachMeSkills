using Microsoft.EntityFrameworkCore;
namespace Ritualka.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<UserOrder> UsersOrders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserOrder>().HasData(
                new UserOrder { Id = 1, Name = "Leon", PhoneNumber = "+375447498228", }
              );
        }
    }
}


