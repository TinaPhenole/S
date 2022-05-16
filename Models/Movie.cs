using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace SFF_Komplettering
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, Range(1, 10)]
        public int Licenses { get; set; }
        [Required]
        public bool isDigital { get; set; }
    }
}