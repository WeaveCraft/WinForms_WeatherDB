using Magic_Astronauts.Core;
using Magic_Astronauts.DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;
using Magic_Astronauts.DataAccess.Models;

namespace Magic_Astronauts;

public partial class Form1 : Form
{
    WeatherDbContext _context = new WeatherDbContext();
    IList<DailyCalc> _avgdata = new List<DailyCalc>();
    public Form1()
    {
        InitializeComponent();
    }
    private void btnnewAVG_Click(object sender, EventArgs e)
    {
        using (_context = new WeatherDbContext())
        {
            _context.WeatherDailies.AddRange(_avgdata);
            DataImport.PopulateDatabase(_context);
            _context.SaveChanges();
        }
        MessageBox.Show("The Database Has Data To Be Viewed", "Save Complete");
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
private void btnMeteoro_Click(object sender, EventArgs e)
    {
        MeteoroSeason display = new();

        DateTime autumnCheck = new DateTime(2016, 10, 01);
        DateTime winterCheck = new DateTime(2016, 10, 01);

        var Autumn = MeteoroCalc.AutumnDate(_context, autumnCheck);
        var Winter = MeteoroCalc.WinterDate(_context, winterCheck);

        if (Autumn == null)
        {
            display.AutumnStart = "Autumn never came in 2016";
        }
        if (Winter == null)
        {
            display.WinterStart = "Winter never came in 2016";
        }
        if (Autumn != null)
        {
            display.AutumnStart = "Meteorological Autumn started: " + Autumn;
        }
        if (Winter != null)
        {
            display.WinterStart = "Meteorological Winter started: " + Winter;
        }

        MessageBox.Show(display.WinterStart + "\n" + display.AutumnStart, "Meteorology Data");
    }

    private void btnDateTimePicker_Click(object sender, EventArgs e)
    {
        var sqlQuery = "SELECT AverageTemperature, Location FROM WeatherDailies WHERE SelectDate = '" + dateTimePicker1.Value + "'";

        var connection = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Trusted_connection=True;");
        var dataAdapter = new SqlDataAdapter(sqlQuery, connection);

        var commandBuilder = new SqlCommandBuilder(dataAdapter);
        var dbData = new DataSet();
        dataAdapter.Fill(dbData);
        dataGridView3.ReadOnly = true;
        dataGridView3.DataSource = dbData.Tables[0];
    }
}
