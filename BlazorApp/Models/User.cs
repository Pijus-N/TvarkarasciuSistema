using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilgas vardas.")]
        public string name { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilga pavardė.")]
        public string lastname { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Per ilgas el. paštas.")]
        public string email { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilgas slaptažodis.")]
        public string password { get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        public string role { get; set; }

    }

}
