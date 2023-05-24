using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models.EFDb7
{
    public class ApplicationContext:DbContext
    {
        //динамический массив эклемпляров класса
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id =1, Name="Leon",Email="holm24",Age = 29},
                new User { Id = 2, Name = "Viktor", Email = "holm24", Age = 29 },
                new User { Id = 3, Name = "Artyom", Email = "holm24", Age = 29 }

            );
        }
    }
}
