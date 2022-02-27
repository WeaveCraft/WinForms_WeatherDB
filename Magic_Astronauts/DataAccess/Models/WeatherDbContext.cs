using Magic_Astronauts.Core;
using Magic_Astronauts.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Magic_Astronauts.DataAccess;

public class WeatherDbContext : DbContext
{
    //private readonly MeteoroSeason _meteoroContext;
    //public WeatherDbContext(MeteoroSeason context)
    //{
    //    _meteoroContext = context;
    //}


    public DbSet<CsvModel> CsvModels { get; set; } 
    public DbSet<WeatherDaily> WeatherDailies { get; set; }
    public DbSet<MouldRisk> MouldRisks { get; set; }
    public DbSet<MeteoroSeason> MeteroSeasons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Integrated Security=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CsvModel>()
            .ToTable("CsvModel");
        modelBuilder.Entity<MouldCalc>()
            .ToTable("MouldRisks");
        modelBuilder.Entity<DailyCalc>()
            .ToTable("WeatherDailies");
    }
    
}
