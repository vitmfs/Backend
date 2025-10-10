using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class BaseControllerDBContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public BaseControllerDBContext(DbContextOptions<BaseControllerDBContext> options) : base(options)
        {

        }
    }
}
