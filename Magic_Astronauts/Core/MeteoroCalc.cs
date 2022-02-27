using Magic_Astronauts.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Astronauts.Core
{
    public class MeteoroCalc
    {
        public static DateTime? AutumnDate(WeatherDbContext context, DateTime? autumnDate)
        {
            int DateInRow = 0;

            var query = (from p in context.WeatherDailies
                         where p.Location == "Ute"
                         select p.AverageTemperature)
                         .ToList();
            var getDateQuery = (from a in context.WeatherDailies
                                where a.Location == "Ute"
                                where a.AverageTemperature < 10 && a.AverageTemperature > 0
                                select a.SelectDate)
                                .ToList();
            var selectQuery = (from q in query
                               where q > 0 && q < 10
                               select q);
            foreach (var temp in selectQuery)
            {
                if (temp < 10 && temp >= 0)
                {
                    DateInRow += 1;
                }
                if (DateInRow == 5)
                {
                    DateTime autumnStart = getDateQuery[0];
                    autumnDate = autumnStart;
                    return autumnDate;
                }
                if (temp > 10 || temp < 0)
                {
                    DateInRow = 0;
                }
            }
            return null;
        }
        //Metod som beräknar när vintern är här genom att den hämtar medeltempratur för utomhus och via loopen som kontrollerar
        //att villkoren för vinter med tempratur under 0 har stämt in fem dagar i rad
        public static DateTime? WinterDate(WeatherDbContext context, DateTime? winterDate)
        {
            int DateInRow = 0;

            var vinterQuery = (from p in context.WeatherDailies
                               where p.Location == "Ute"
                               select p.AverageTemperature)
                         .ToList();
            var getDateQuery = (from a in context.WeatherDailies
                                where a.Location == "Ute"
                                where a.AverageTemperature <= 0
                                select a.SelectDate)
                                .ToList();
            var selectVinter = (from q in vinterQuery
                                where q < 0
                                select q);
            foreach (var temp in selectVinter)
            {
                if (temp <= 0)
                {
                    DateInRow += 1;
                }
                if (DateInRow == 5)
                {
                    DateTime winterStart = getDateQuery[0];
                    winterDate = winterStart;
                    return winterDate;
                }
                if (temp > 0)
                {
                    DateInRow = 0;
                }
            }
            return null;
        }


    }
}
