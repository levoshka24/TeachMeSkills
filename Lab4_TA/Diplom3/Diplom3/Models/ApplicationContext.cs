using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Diplom3.Models
{
    public class ApplicationContext : DbContext
    { 
        //список экзмепляров класса,который сопоставляется с таблицкй в бд
        public DbSet<PhoneConsult> Phones { get; set; }
       public DbSet<Course> Courses { get; set; }
       public DbSet<Comment> Comments { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PhoneConsult>().HasData(
        //        new PhoneConsult { Id = 1, PhoneNumber = "+375447498228", Email = "holmov24@mail.ru" }
        //      );
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Comment>().HasData(
        //        new Comment { Id = 1, Name = "Leon", Commenter = "Отличный курс,теория нескучная и очень интересная", CourseName = "C#" }
        //      );
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Course>().HasData(
        //        new Course { Id = 1, CourseName = "C#", Name = "Виктор", Email = "holmov24@mail.ru" }
        //      );
        //}
    }
}
