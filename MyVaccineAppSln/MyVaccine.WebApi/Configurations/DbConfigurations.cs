using Microsoft.EntityFrameworkCore;
using MyVaccine.WebApi.Literals;
using MyVaccine.WebApi.Models;

namespace MyVaccine.WebApi.Configurations
{
    public static  class DBConfigurations
    {
        public static IServiceCollection SetDataBaseConfiguration(this IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable(MyVaccineLiterals.CONNECTION_STRING)
            ;
            //var connectionString = "Server=localhost,14333;Database=MyVaccineAppDb;User Id=SA;Password=Debian1419*;TrustServerCertificate=True;";
            services.AddDbContext<MyVaccineAppDbContext>(options =>
    options.UseSqlServer(connectionString));

            return services;
        }
    }
}
