namespace SFF_Komplettering
{
    public class Rental : BaseEntity
    {
        public Movie Movie { get; set; }
        public FilmAssociation FilmAssociation { get; set; }
    }
}