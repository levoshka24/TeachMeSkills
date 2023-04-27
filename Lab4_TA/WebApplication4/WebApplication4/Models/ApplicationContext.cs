using System.Collections.Generic;
using System.Reflection.Emit;
using WebApplication4.Models.EBDb2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebApplication4.Models
{
    public class ApplicationContext:DbContext
    {

        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            

                
        //    modelBuilder.Entity<Sparga>().HasData(
        //        new Sparga { Id = 1, Name = "Успех", CountOfPages = "200"},
        //   new Sparga { Id = 2, Name = "Успех", CountOfPages = "200" },
        //   new Sparga { Id = 3, Name = "Успех", CountOfPages = "200" },
        //   new Sparga { Id = 4, Name = "Успех", CountOfPages = "200"},
        //   new Sparga { Id = 5, Name = "Успех", CountOfPages = "200" }

        //         );
        //}
    }
}

