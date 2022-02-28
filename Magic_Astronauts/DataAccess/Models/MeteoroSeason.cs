using System.ComponentModel.DataAnnotations;

namespace Magic_Astronauts.DataAccess.Models
{
    public class MeteoroSeason
    {
        [Required]
        public int Id { get; set; }
        public string? AutumnStart { get; set; }
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        //public DateTime? AutumnDateTime { get; set; }
        public string? WinterStart { get; set; }
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        //public DateTime? WinterDateTime { get; set; }
    }
}
