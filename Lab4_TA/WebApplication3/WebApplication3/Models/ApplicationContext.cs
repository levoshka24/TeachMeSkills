using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.TMS_HW;

namespace WebApplication3.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Успех" },
           new Author { Id = 2, Name = "Успех",  }
           
                );
        //    modelBuilder.Entity<Book>().HasData(
        //        new Book { Id = 1, Name = "Успех", CountOfPages = 200, Author = "Инфоцыган", },
        //   new Book { Id = 2, Name = "Успех", CountOfPages = 200, Author = "Инфоцыган" },
        //   new Book { Id = 3, Name = "Успех", CountOfPages = 200, Author = "Инфоцыган" },
        //   new Book { Id = 4, Name = "Успех", CountOfPages = 200, Author = "Инфоцыган" },
        //   new Book { Id = 5, Name = "Успех", CountOfPages = 200, Author = "Инфоцыган" }

        //    //     );
        }
    }
}
