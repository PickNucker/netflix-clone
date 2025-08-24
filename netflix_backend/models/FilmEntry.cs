using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netflix_backend.models
{
    public class FilmEntry
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Range(0, 10)]
        public double Rating { get; set; }
    }
}