using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inleveropdr_v2_Webapps.Models
{
    public class ProjectenTransactie
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string projectNaam { get; set; }

        [Required]
        public string projectCategorie { get; set; }
    }
}
