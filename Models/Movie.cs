using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace SFF_Komplettering
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, Range(1, 10)]
        public int Licenses { get; set; }
        [Required]
        public bool isDigital { get; set; }
    }
}