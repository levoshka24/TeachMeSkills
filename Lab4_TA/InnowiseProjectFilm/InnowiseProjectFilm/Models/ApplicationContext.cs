using Microsoft.EntityFrameworkCore;

namespace InnowiseProjectFilm.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Question> Question { get; set; }
        public DbSet<Commentor> Commentaries { get; set; }
        public DbSet<Film> Films { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
