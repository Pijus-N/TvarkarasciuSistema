using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Homework
    {
        public int id { get; set; }
        [Required]
        public DateTime assignment_date { get; set; }
        [Required]
        public DateTime completion_data { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public int isDeleted { get; set; }
        [Required]
        public int teacher_id { get; set; }
        [Required]
        public int lesson_id { get; set; }
        [Required]
        public int student_id { get; set; }



    }

}
