using Magic_Astronauts.DataAccess;
using Magic_Astronauts.DataAccess.Models;

namespace Magic_Astronauts.Core
{
    public class MouldCalc : MouldRisk
    {
        // Method that adds a message for each MouldIndex to our DB.
        public static string MouldText(string mould)
        {
            double risk = double.Parse(mould);
            if (risk == 0)
            {
                mould = "Ingen Risk För Mögel";
            }
            if (risk == 1)
            {
                mould = "Möjlig mögel växt efter 8 veckor";
            }
            if (risk == 2)
            {
                mould = "Mögel växt efter 4 till 8 veckor";
            }
            if (risk == 3)
            {
                mould = "Hög risk för mögel växt inom 4 veckor";
            }
            return mould;
        }
        // Method to get data for each days mouldrisk to MouldRisk Table in DB.
        public static void PopulateMouldRisk(WeatherDbContext context, string position)
        {

            var Days = from d in context.WeatherDailies
                       where d.Location == position
                       orderby d.SelectDate ascending
                       select d;
            foreach (var d in Days)
            {
                int temp = (int)Math.Round((d.AverageTemperature), 0);
                int humid = (int)Math.Round((d.AverageHumidity), 0);
                DateTime day = d.SelectDate;
                int mouldRisk = 0;
                if (temp < 0 || temp > 50 || humid < 78)
                {
                    mouldRisk = 0;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (humid < MouldInfo._MouldTable[temp, i])
                        {
                            mouldRisk = i - 1;
                            break;
                        }
                        else
                        {
                            mouldRisk = 3;
                        }
                    }
                }

                // Write out our calculations together with our string for mould level -> MouldRisk + MouldText.

                string MouldFacts = MouldText(mouldRisk.ToString());
                var _MouldRisk = new MouldCalc { SelectDate = day, RiskForMould = MouldFacts, Location = position, MouldIndex = mouldRisk };
                context.MouldRisks.Add(_MouldRisk);
            }
            context.SaveChanges();
        }
    }
}
