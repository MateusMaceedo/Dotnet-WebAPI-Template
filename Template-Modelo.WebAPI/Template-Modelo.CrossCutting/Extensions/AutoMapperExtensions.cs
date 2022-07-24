using Microsoft.Extensions.DependencyInjection;
using Template_Modelo.Application.Mappers;

namespace Template_Modelo.CrossCutting.Extensions
{
    public class AutoMapperExtensions
    {
        public static void ConfigurarAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EntityToModelProfile));
            services.AddAutoMapper(typeof(ModelEntityToProfile));
        }
    }
}
