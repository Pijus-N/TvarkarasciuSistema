using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Lesson
    {
        public int id { get; set; }
        public int teacher_id { get; set; }
        public string location { get; set; }
        [Required]
        public DateTime start_time { get; set; }
        [Required]
        public int length { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Per ilga pavardė.")]
        public string instrument { get; set; }
        [Required]
        public int student_count { get; set; }
        [Required]
        public string lesson_type { get; set; }


    }

}
