using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Pamoka
    {
        public int id { get; set; }
        public int teacher_id { get; set; }
        public string place { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilga pavardė.")]
        public string instrument { get; set; }
        [Required]
        public string students_count { get; set; }
        [Required]
        public string date { get; set; }
        
        public DateTime dateInFormat { get; set; }
        [Required]
        public int time { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public string price { get; set; }

    }

}
