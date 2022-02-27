using System.Globalization;

namespace Magic_Astronauts.Core
{
    public class CsvConverter : Weather
    {
        public static void Converter(string csvLine, out Weather data)
        {
            data = new Weather();
            DateTime date;
            string location;
            decimal temp;
            int humidity;
            string[] values = csvLine
                .Trim()
                .Split(',');


            foreach (var value in values)
            {
                date = DateTime.Parse(values[0]);
                location = values[1];
                if (decimal.TryParse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture, out decimal result))
                {
                    temp = result;
                }
                else
                {
                    break;

                }
                humidity = int.Parse(values[3]);

                data = new Weather
                {
                    Date = date,
                    Location = location,
                    Temp = temp,
                    Humidity = humidity
                };
            }
            

            

            //data = new Weather
            //{
            //    Date = DateTime.Parse(values[0]),
            //    Location = values[1],
            //    Temp = float.Parse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture),
            //    Humidity = int.Parse(values[3])
            //};
            //return data;

            //data.Date = DateTime.ParseExact(values[0].Substring(0, 10), "yyyy-MM-dd", CultureInfo.CurrentCulture);
            //data.Location = values[1];
            //data.Temp = float.Parse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture);
            //data.Humidity = int.Parse(values[3]);
            //return data;

            //, "yyyy-MM-dd H:mm", svSE, DateTimeStyles.AllowInnerWhite
        }
    }
}
