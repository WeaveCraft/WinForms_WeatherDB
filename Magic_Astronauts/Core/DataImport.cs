using Magic_Astronauts.DataAccess;

namespace Magic_Astronauts.Core
{
    public class DataImport
    {
        public static void PopulateDatabase(WeatherDbContext context) //Imports Data into DB
        {
            CsvImport.CsvBuilder(context);
            if (!context.WeatherDailies.Any())
            {
                DailyCalc.PopulateAvgTempAndHumidity(context);
            }
            if (!context.MouldRisks.Any())
            {
                MouldCalc.PopulateMouldRisk(context, "Ute");
                MouldCalc.PopulateMouldRisk(context, "Inne");
            }
            context.SaveChanges();
        }
    }
}
