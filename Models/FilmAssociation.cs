using System.ComponentModel.DataAnnotations;

namespace SFF_Komplettering
{
    public class FilmAssociation : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}