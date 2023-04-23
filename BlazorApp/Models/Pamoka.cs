using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Pamoka
    {
        public int id { get; set; }
        public int mokytojo_id { get; set; }
        public string vietove { get; set; }
        [Required]
        public DateTime pamokos_pradzia { get; set; }
        [Required]
        public int pamokos_trukme { get; set; }
        [Required]
        public string kaina { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilga pavardė.")]
        public string instrumentas { get; set; }
        [Required]
        public string mokiniu_skaicius { get; set; }
        [Required]
        public string pamokos_tipas { get; set; }


    }

}
