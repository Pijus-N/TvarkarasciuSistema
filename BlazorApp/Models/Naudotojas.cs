using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Naudotojas
    {
        public int id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilgas vardas.")]
        public string vardas { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilga pavardė.")]
        public string pavarde { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Per ilgas el. paštas.")]
        public string elPastas { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilgas slaptažodis.")]
        public string slaptazodis { get; set; }
        [Required]
        public DateOnly gimimoData { get; set; }
        public string role { get; set; }

    }

}
