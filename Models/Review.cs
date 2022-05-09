using System.ComponentModel.DataAnnotations;

namespace SFF_Komplettering
{
    public class Review : BaseEntity
    {
        public Movie Movie { get; set; }
        public FilmAssociation FilmAssociation { get; set; }
        [Required, Range(1, 5)]
        public int ScoreValue { get; set; }
        public string ReviewTitle { get; set; }
        [StringLength(750)]
        public string ReviewContent { get; set; }
    }
}