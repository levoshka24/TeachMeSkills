using WebApplication11.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace WebApplication11.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<PhoneConsult> Phones { get; set; }
        public DbSet<NewCourse> NewCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        

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
        //        new Course { Id = 1,  Name = "HTML", CourseName="flf", Email="fkf" }
        //      );
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<NewCourse>().HasData(
        //        new NewCourse { Id = 1, Name = "CSS", Descriptionsis="Новое" }
        //      );
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AllСourses>().HasData(
        //        new AllСourses { Id = 1, Name="HTML" }
        //        );
        //}

    }
}