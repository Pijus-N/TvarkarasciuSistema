using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Teacher
    {
        public int id { get; set; }
        public string instrument {get; set;}
        public string location { get; set;}
        public double price { get; set;}
        public double group_price { get; set;}
        public int user_id { get; set; }
    }

}
