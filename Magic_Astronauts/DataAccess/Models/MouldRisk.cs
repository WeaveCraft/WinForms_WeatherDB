using System.ComponentModel.DataAnnotations;

namespace Magic_Astronauts.DataAccess.Models
{
    public class MouldRisk
    {
        [Required]
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime SelectDate { get; set; }
        public string Location { get; set; }
        public string RiskForMould { get; set; } //Information about the mould scale (0-3)
        public int MouldIndex { get; set; } //What level is the mould risk at (from scale 0-3)
    }
}
