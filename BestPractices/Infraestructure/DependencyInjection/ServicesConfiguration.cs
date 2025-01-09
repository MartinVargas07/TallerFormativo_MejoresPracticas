using Best_Practices.Infraestructure.Factories;
using Best_Practices.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Best_Practices.Infraestructure.DependencyInjection
{
    public class ServicesConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Repositorio InMemory
            services.AddScoped<IVehicleRepository, MyVehiclesRepository>();

            // Factories
            services.AddTransient<FordMustangCreator>();
            services.AddTransient<FordExplorerCreator>();

        }
    }
}
