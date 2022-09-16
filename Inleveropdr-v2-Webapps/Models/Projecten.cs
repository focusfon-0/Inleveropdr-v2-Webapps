using System.ComponentModel.DataAnnotations;

namespace Inleveropdr_v2_Webapps.Models
{
    public class Projecten
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string projectNaam { get; set; }
        public string projectCategorie { get; set; }
        public int verdienstenBijAfronden { get; set; }
        public DateTime beschikbaarVanaf { get; set; } = DateTime.Now; 
    }
}
