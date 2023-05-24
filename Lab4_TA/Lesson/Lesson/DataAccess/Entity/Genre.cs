using System.ComponentModel.DataAnnotations;

namespace Lesson.DataAccess.Entity
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        [MaxLength(85)]
        public string Name { get; set; }

        public virtual ICollection<Film> Films { get; set; }

    }
}
