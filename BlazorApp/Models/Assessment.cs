namespace BlazorServer.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public string Note { get; set; }
        public bool Attendance { get; set; }
        public int lesson_id { get;set; }
        public int student_id { get; set; }
    }

}
