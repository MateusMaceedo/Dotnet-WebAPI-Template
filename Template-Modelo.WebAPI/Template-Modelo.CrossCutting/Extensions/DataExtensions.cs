using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Template_Modelo.Domain.Interfaces.DataConnector;
using Template_Modelo.Infra.Data.DataConnector;

namespace Template_Modelo.CrossCutting.Extensions
{
    public static class DataExtensions
    {
        public static void ConfigurarDbConnector(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("default");
            services.AddScoped<IDbConnector>(db => new SqlConnector(connectionString));
        }
    }
}
