namespace Magic_Astronauts.Core;

public class Weather
{
    public int WeatherID { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public decimal Temp { get; set; }
    public int Humidity { get; set; }
}
