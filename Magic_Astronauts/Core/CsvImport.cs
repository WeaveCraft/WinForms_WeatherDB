namespace Magic_Astronauts.DataAccess
{
    public class CsvImport
    {
        // Save csv file into a string for later use.
        public static string csv_file_path = @"C:\Users\Vikto\source\repos\Magic Astronauts\TempFuktData.csv"; //TODO FIXA so different computers can use the csv_file_path without chaning the string.
        public static void CsvBuilder(WeatherDbContext context)
        {
            // Read in sorted data from method and save in variable.
            var read = ReadCsv();

            // If data can be found in DB, display message.
            context.Database.EnsureCreated();
            if (context.CsvModels.Any())
            {
                MessageBox.Show("Data found in Database, please remove old data before you insert new", "Magic Astronauts");
            }
            else
            {
                // Check if CSV File has data, if not display message.
                if (read == null)
                {
                    MessageBox.Show("There is no data to import!", "Magic Astronauts");
                }
                // If DB is empty we BulkInsert using nugget package Z.EntityFramework.Extensions.EFCore.
                else
                {
                    context.CsvModels.BulkInsert(read);
                }
            }
        }
        public static List<CsvModel> ReadCsv()
        {
            // Open stream to file, read all data.
            List<string> CsvData = File.ReadAllLines(csv_file_path).Distinct().ToList();
            List<CsvModel> SortedList = new List<CsvModel>();
            foreach (string item in CsvData)
            {
                // Divide string inputs from file and remove commas.
                string[] values = item.Split(',');
                CsvModel csvClass = new CsvModel();
                // Give properties value and parse values from string seperated array.
                try
                {
                    csvClass.Date = DateTime.Parse(values[0]);
                    csvClass.Location = values[1];
                    var variable = values[2].Replace('.', ',')
                                            .Replace('−', '-');
                    csvClass.Temp = double.Parse(variable);
                    csvClass.Humidity = int.Parse(values[3]);
                    SortedList.Add(csvClass);
                }
                // Catch format error and set temp to 0 because double cant be null.
                catch (FormatException)
                {
                    string s = values[2];
                    csvClass.Temp = 0;
                }
                // Catch Overflow during assert and set temp to 0 because double cant be null.
                catch (OverflowException)
                {
                    csvClass.Temp = 0;
                }
                // Cath exception for display to user.
                catch (Exception em)
                {
                    MessageBox.Show("Something went wrong", "Error Message");
                }
            }
            return SortedList;
        }
    }
}
