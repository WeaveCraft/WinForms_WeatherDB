using Magic_Astronauts.Core;
using Magic_Astronauts.DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Magic_Astronauts;

public partial class Form1 : Form
{
    WeatherDbContext _context = new WeatherDbContext();
    IList<Weather> weatherData = new List<Weather>();
    IList<string> lineData = new List<string>();
    IList<DailyCalc> _avgdata = new List<DailyCalc>();
    //Regex filter = new Regex(@"^[\d{4}-\w,:.]");
    public Form1()
    {
        _context.Database.EnsureCreated(); //Skapar dbn när programmet startar
        InitializeComponent();
    }

    private void Browse_btn_Click(object sender, EventArgs e)
    {
        //openFileDialog1 = new OpenFileDialog()
        //{
        //    Title = "Select File",
        //    Filter = "CSV File (*.csv)|*.csv",
        //    FilterIndex = 1,
        //    RestoreDirectory = true
        //}

        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Title = "Select File";
        fileDialog.FileName = txtFileName.Text;
        fileDialog.Filter = "CSV File (*.csv)|*.csv";
        fileDialog.FilterIndex = 1;
        fileDialog.RestoreDirectory = true;
        if (fileDialog.ShowDialog() == DialogResult.OK)
        {
            txtFileName.Text = fileDialog.FileName;
        }
        lineData = File.ReadAllLines(txtFileName.Text)
        .Skip(1)
        .Distinct()
        .ToList();

        //for (int i = 0; i < lineData.Count; i++)
        //{
        //    foreach (var line in lineData)
        //    {
        //        if (!line.Contains("â"))
        //        {
        //            CsvConverter.Converter(line, out var data);
        //            weatherData.Add(data);
        //        }
        //        //CsvConverter.Converter(line, out var data);
        //        //weatherData.Add(data);
        //    }
        //}

        //.Where(x => filter.IsMatch(x))
        //.Select(x => CsvConverter.Converter(x))
        //.ToList();
        //dataGridView1.DataSource = weatherData;
        //txtFileName.Clear();
    }
    private void saveBtn_Click(object sender, EventArgs e)
    {
        using (_context = new WeatherDbContext())
        {
            _context.Weathers.AddRange(weatherData);
            _context.SaveChanges();
        }
        MessageBox.Show(Text, "Saved Successful", MessageBoxButtons.OK);
    }

    private void load_Btn_Click(object sender, EventArgs e)
    {
        if (txtFileName.Text != null)
        {
            try
            {
                //List<string> lines = lineData
                //    .Where(x => filter.IsMatch(x))
                //        .ToList();
                for (int i = 0; i < lineData.Count; i++)
                {
                    CsvConverter.Converter(lineData[i], out var data);
                    if (data.Location != null)
                    {
                        weatherData.Add(data);
                    }
                    else
                    {
                        continue;
                    }
                }
                //foreach (var line in lineData)
                //{
                //    CsvConverter.Converter(line, out var data);
                //    weatherData.Add(data);
                //}
                dataGridView1.DataSource = weatherData;
                txtFileName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        else
        {
            var selectQuery = "SELECT * FROM Weathers WHERE WeatherID % 2 != 0 AND Location LIKE 'Ute'OR WeatherID % 2 = 0 AND Location LIKE 'Inne'";

            var connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Integrated Security=True;");
            var dataAdapter = new SqlDataAdapter(selectQuery, connect);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dbData = new DataSet();
            dataAdapter.Fill(dbData);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dbData.Tables[0];
        }
    }
    private void btnnewAVG_Click(object sender, EventArgs e)
    {
        using (_context = new WeatherDbContext())
        {
            _context.WeatherDailies.AddRange(_avgdata);
            DataImport.PopulateDatabase(_context);
            _context.SaveChanges();
        }
        MessageBox.Show("The Database now has fresh data to be viewed!", "Save Complete");
    }

    private void btnShowAvg_Click(object sender, EventArgs e)
    {
        var selectQuery = "SELECT SelectDate, AverageHumidity, AverageTemperature, Location FROM WeatherDailies";

                        

        var connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Integrated Security=True;");
        var dataAdapter = new SqlDataAdapter(selectQuery, connect);

        var commandBuilder = new SqlCommandBuilder(dataAdapter);
        var dbData = new DataSet();
        dataAdapter.Fill(dbData);
        dataGridView2.ReadOnly = true;
        dataGridView2.DataSource = dbData.Tables[0];
    }

    private void btnMoldRisk_Click(object sender, EventArgs e)
    {
        var selectQuery = "SELECT SelectDate, Location, RiskForMould, MouldIndex FROM MouldRisks";

                        

        var connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Integrated Security=True;");
        var dataAdapter = new SqlDataAdapter(selectQuery, connect);

        var commandBuilder = new SqlCommandBuilder(dataAdapter);
        var dbData = new DataSet();
        dataAdapter.Fill(dbData);
        dataGridView1.ReadOnly = true;
        dataGridView1.DataSource = dbData.Tables[0];
    }
}

