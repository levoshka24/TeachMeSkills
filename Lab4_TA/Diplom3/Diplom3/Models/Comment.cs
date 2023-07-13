using System.ComponentModel.DataAnnotations;

namespace Diplom3.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string CourseName { get; set; }
        public string Name { get; set; }
        [StringLength(2000, MinimumLength = 5, ErrorMessage = "Длина строки должна быть от 5 до 2000 символов")]
        public string Commenter { get; set; }
    }
}
