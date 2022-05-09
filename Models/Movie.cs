using System;
using System.ComponentModel.DataAnnotations;

namespace SFF_Komplettering
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Licenses { get; set; }
        [Required]
        public bool isDigital { get; set; }
    }
}