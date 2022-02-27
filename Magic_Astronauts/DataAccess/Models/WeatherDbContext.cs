using Magic_Astronauts.Core;
using Microsoft.EntityFrameworkCore;

namespace Magic_Astronauts.DataAccess;

public class WeatherDbContext : DbContext
{
    public DbSet<Weather> Weathers { get; set; } //Samma som CsvModels. Ish.
    public DbSet<CsvModel> CsvModels { get; set; } //Denna är detsamma som Weathers table. Vi kan ta bort Weathers eller CsvModels.
    public DbSet<DailyCalc> WeatherDailies { get; set; }
    public DbSet<MouldCalc> MouldRisks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MagicAstronauts;Integrated Security=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Weather>(entity =>
        {
            entity.HasKey(e=> e.WeatherID);

        });
        modelBuilder.Entity<CsvModel>()
            .ToTable("CsvModel");
        modelBuilder.Entity<MouldCalc>()
            .ToTable("MouldRisks");
        modelBuilder.Entity<DailyCalc>()
            .ToTable("WeatherDailies");
    }
    
}
