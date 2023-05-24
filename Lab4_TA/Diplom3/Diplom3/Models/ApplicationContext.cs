using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Diplom3.Models
{
    public class ApplicationContext : DbContext
    { 
        public DbSet<PhoneConsult> Phones { get; set; }
        public DbSet<UserLogIn> UserLogIns { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PhoneConsult>().HasData(
        //        new PhoneConsult {Id = 1, PhoneNumber = "+375447498228"}
        //      );
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogIn>().HasData(
                new UserLogIn { Id = 1,Email = "admin", Password = "admin"  }
              );
        }
    }
}
