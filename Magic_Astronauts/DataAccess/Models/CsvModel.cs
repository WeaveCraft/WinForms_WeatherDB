using System.ComponentModel.DataAnnotations;

namespace Magic_Astronauts.DataAccess
{
    public class CsvModel
    {
        [Required]
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public double Temp { get; set; }
        public double Humidity { get; set; }
    }
}
