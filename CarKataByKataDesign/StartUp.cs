using CarKataByKataDesign.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CarKataByKataDesign
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

           
            services.AddTransient<EntryPoint>();
            services.AddSingleton<ICar, Car>();
            services.AddSingleton<ICar, Car>();
            services.AddSingleton<IFuel, Fuel>();
            services.AddSingleton<IEngine, Engine>();
            services.AddSingleton<IDriving, Driving>();
            services.AddSingleton<ICarDashboard, CarDashboard>();
            services.AddSingleton<IFuelDisplay, FuelDisplay>();

            return services;
        }
    }
}