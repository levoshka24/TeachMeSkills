using HW_BOOK.Models.EBDb2;
using Microsoft.EntityFrameworkCore;

namespace HW_BOOK.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id =1, Name = "�����", Author="���������", CountOfPages = 200},
             new Book { Id = 2, Name = "�����", Author = "���������", CountOfPages = 200 },
              new Book { Id = 3, Name = "�����", Author = "���������", CountOfPages = 200 },
               new Book { Id = 4, Name = "�����", Author = "���������", CountOfPages = 200 },
                new Book { Id = 5, Name = "�����", Author = "���������", CountOfPages = 200 }
            );
    }
    
}