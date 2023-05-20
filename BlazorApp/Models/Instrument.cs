using System.ComponentModel.DataAnnotations;
namespace BlazorServer.Models
{
    public class Instrument
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        [Required]
        public double rental_price { get; set; }
        [Required]
        public string instrument_type { get; set; }
        public string instrument_state { get; set; }
        public int renter_id { get; set; }
    }

}
