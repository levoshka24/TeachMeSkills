﻿using System.ComponentModel.DataAnnotations;

namespace Lesson.DataAccess.Entity
{
    public class Film
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(85)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string YoutubeId { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public int GenreId { get; set; }

        [Required]
        public string ImageXPath { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

    }
}
