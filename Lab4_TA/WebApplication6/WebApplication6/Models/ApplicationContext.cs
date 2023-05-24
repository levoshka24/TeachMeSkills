using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id =1,Name = "Leon", Female = " Khalmou"},
                new User { Id =2,Name = "Viktor", Female = "Ridnkg"},
                new User { Id =3,Name = "Anton", Female = " Nowkow"}
                );
        }
    }
}
